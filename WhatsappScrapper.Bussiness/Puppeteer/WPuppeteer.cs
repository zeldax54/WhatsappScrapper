using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PuppeteerSharp;
using System;
using System.Net;
using Whatsapp.ApiConsumer.Identity;
using WhatsappScrapper.Bussiness.ClientNotifier;
using WhatsappScrapper.Bussiness.FileStorage;
using WhatsappScrapper.Bussiness.ImageProcessor;
using WhatsappScrapper.DataAccess.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WhatsappScrapper.Bussiness.Puppeteer
{
    public class WPuppeteer : IWPuppeteer
    {
            
        IChromiumFileManager _chromiumFileManager;
        IImageProcessor _imageProcessor;
        private readonly IHubContext<Notifier> _notifierContext;
        private readonly IConfiguration _configuration;
        private readonly INumberRegistrationRepository _numberRegistrationRepository;
        private readonly IIdentityConsumer _identityConsumer;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WPuppeteer(IChromiumFileManager chromiumFileManager, IImageProcessor imageProcessor,
            IHubContext<Notifier> notifierContext, IConfiguration configuration,
            INumberRegistrationRepository numberRegistrationRepository, IIdentityConsumer identityConsumer, IHttpContextAccessor httpContextAccessor) 
        {
            _chromiumFileManager = chromiumFileManager;
            _imageProcessor = imageProcessor;
            _notifierContext = notifierContext;
            _configuration = configuration;
            _numberRegistrationRepository = numberRegistrationRepository;
            _identityConsumer = identityConsumer;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task Configure(string number,string waitforQR,string waitForEnd) 
        {
            var fileInfo = await _chromiumFileManager.PrepareFolder(number);

            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(_configuration["version"]);

            await using var browser = await PuppeteerSharp.Puppeteer.LaunchAsync(
                new LaunchOptions { 
                    Headless = true, 
                    ExecutablePath = browserFetcher.GetExecutablePath(_configuration["version"]),
                    UserDataDir = fileInfo.UserData,
                    Args = new string[2] { "--start-maximized", "--no-sandbox" },
                });         

            await using var page = await browser.NewPageAsync();
            await page.SetUserAgentAsync(_configuration["userAgent"]);

            await page.GoToAsync(_configuration["whatsappUrl"]);
            bool waitforselector = bool.Parse(_configuration["waitforselector"]);
           
            if(waitforselector)
              await page.WaitForSelectorAsync(_configuration["qrSelector"]);
            else
                await page.WaitForTimeoutAsync(int.Parse(waitforQR)*1000);


            var picPath = fileInfo.ScreenFolder + "//qrscreen.png";          
            await page.ScreenshotAsync(picPath);
            var base64 = await _imageProcessor.LoadScreenShootAsBase64(picPath);
            await _notifierContext.Clients.All.SendAsync("RegistrationQr", base64);//Send QR img to client

            await page.WaitForTimeoutAsync(int.Parse(waitForEnd)*1000);//wait for scan qr      
           
            var picPathEnd = fileInfo.ScreenFolder + "//registrationTestscreen.png";
            await page.ScreenshotAsync(picPathEnd);
            var base64End = await _imageProcessor.LoadScreenShootAsBase64(picPathEnd);
            await _notifierContext.Clients.All.SendAsync("RegistrationEndTest", base64End);//Send QR img to client

           var cookiesObject = await page.GetCookiesAsync();
           var cookiesJson = JsonConvert.SerializeObject(cookiesObject, Formatting.Indented);
           await _chromiumFileManager.SaveCookies(fileInfo.CookiesFolder, cookiesJson, number);

           /* HttpContext httpContext = _httpContextAccessor.HttpContext;
            string? accessToken = httpContext.Request.Headers["Authorization"].
            ToString();*/
            var userInfo = await  _identityConsumer.UserInfo();   
           
            await _numberRegistrationRepository.Create(new WhatsAppScrapper.Models.DataModels.RegisterNumber() {
            UserId = userInfo.Data.UserId,
            UserName = userInfo.Data.UserName,
            Number = number,
            SettingsDir = fileInfo.DataRoot
            });

           await page.CloseAsync();
           await browser.CloseAsync();
        }
       
        public async Task<string> LoadPage(string number)
        {
            var fileInfo = await _chromiumFileManager.PrepareFolder(number);
           
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(_configuration["version"]);

            var browser = await PuppeteerSharp.Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                ExecutablePath = browserFetcher.GetExecutablePath(_configuration["version"]),
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

        public async Task RemoveConfig(string configdir)
        {
           await _chromiumFileManager.RemoveConfig(configdir);          
        }
    }
}
