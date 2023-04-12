using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using PuppeteerSharp;
using System;
using System.Net;
using WhatsappScrapper.Bussiness.ClientNotifier;
using WhatsappScrapper.Bussiness.FileStorage;
using WhatsappScrapper.Bussiness.ImageProcessor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WhatsappScrapper.Bussiness.Puppeteer
{
    public class WPuppeteer : IWPuppeteer
    {
        /// <summary>
        /// Configs
        /// </summary>
        string version = "1095492";
        string whatsappUrl = "https://web.whatsapp.com/";
        string userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36";
        int waitTimeforRegistration = 5000;
       /// <summary>
       /// End config
       /// </summary>
        
        IChromiumFileManager _chromiumFileManager;
        IImageProcessor _imageProcessor;
        private readonly IHubContext<Notifier> _notifierContext;

        public WPuppeteer(IChromiumFileManager chromiumFileManager, IImageProcessor imageProcessor, IHubContext<Notifier> notifierContext) 
        {
            _chromiumFileManager = chromiumFileManager;
            _imageProcessor = imageProcessor;
            _notifierContext = notifierContext;
        }

        public async Task Configure(string number) 
        {
            var fileInfo = await _chromiumFileManager.PrepareFolder(number);

            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(version);

            await using var browser = await PuppeteerSharp.Puppeteer.LaunchAsync(
                new LaunchOptions { 
                    Headless = true, 
                    ExecutablePath = browserFetcher.GetExecutablePath(version),
                    UserDataDir = fileInfo.UserData
                });         

            await using var page = await browser.NewPageAsync();
            await page.SetUserAgentAsync(userAgent);

            await page.GoToAsync(whatsappUrl);
            await page.WaitForTimeoutAsync(waitTimeforRegistration);
           
            var picPath = fileInfo.ScreenFolder + "//qrscreen.png";          
            await page.ScreenshotAsync(picPath);
            var base64 = await _imageProcessor.LoadScreenShootAsBase64(picPath);
            await _notifierContext.Clients.All.SendAsync("RegistrationQr", base64);//Send QR img to client

            await page.WaitForTimeoutAsync(10000);//wait for scan qr      
           
            var picPathEnd = fileInfo.ScreenFolder + "//registrationTestscreen.png";
            await page.ScreenshotAsync(picPathEnd);
            var base64End = await _imageProcessor.LoadScreenShootAsBase64(picPathEnd);
            await _notifierContext.Clients.All.SendAsync("RegistrationEndTest", base64End);//Send QR img to client

           var cookiesObject = await page.GetCookiesAsync();
           var cookiesJson = JsonConvert.SerializeObject(cookiesObject, Formatting.Indented);
           await _chromiumFileManager.SaveCookies(fileInfo.CookiesFolder, cookiesJson, number);     
           
           await page.CloseAsync();
           await browser.CloseAsync();
        }

       
        public async Task<string> LoadPage(string number)
        {
            var fileInfo = await _chromiumFileManager.PrepareFolder(number);
           
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(version);

            var browser = await PuppeteerSharp.Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                ExecutablePath = browserFetcher.GetExecutablePath(version),
                UserDataDir = fileInfo.UserData
            });

            var page = await browser.NewPageAsync();

            var cookiesJson =await _chromiumFileManager.ReadCookies(number, fileInfo.CookiesFolder);

            // Convertir el JSON en una lista de cookies
            var cookies = JsonConvert.DeserializeObject<List<CookieParam>>(cookiesJson);

            // Establecer las cookies en la página
            foreach (var cookie in cookies)
            {
                await page.SetCookieAsync(cookie);
            }

            await page.GoToAsync("https://localhost/mi-pagina-con-cookies");

            await browser.CloseAsync();
            return "";
        }


    }
}
