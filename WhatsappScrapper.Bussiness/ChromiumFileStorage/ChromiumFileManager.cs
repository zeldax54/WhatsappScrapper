using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsappScrapper.Bussiness.FileStorage;
using WhatsAppScrapper.Models;

namespace WhatsappScrapper.Bussiness.ChromiumFileStorage
{
    public class ChromiumFileManager : IChromiumFileManager
    {
        string _directory = Environment.CurrentDirectory;
        string _prefix = "chromiumsettings";
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public ChromiumFileManager(IWebHostEnvironment webHostEnvironment, IConfiguration configuration) 
        { 
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        public Task<ChromiunFileData> PrepareFolder(string number)
        {           
            var filePathUserData = Path.Combine(_directory, _prefix, number+"//userdata");
            var logFile = Path.Combine(_directory, _prefix, number + "//Log");
            var cookiesFolder = Path.Combine(_directory, _prefix, number + "//cookies");          
            var screenFolder = Path.Combine(_directory, _prefix, number + "//screens");          
            
            if (!Directory.Exists(filePathUserData))
                Directory.CreateDirectory(filePathUserData);
            if (!Directory.Exists(logFile))
                Directory.CreateDirectory(logFile);
            if (!Directory.Exists(cookiesFolder))
                Directory.CreateDirectory(cookiesFolder);
            if (!Directory.Exists(screenFolder))
                Directory.CreateDirectory(screenFolder);

            return Task.FromResult(new ChromiunFileData() {
                UserData = filePathUserData,
                LogFile = logFile+ "//Debug.log",
                CookiesFolder = cookiesFolder,
                ScreenFolder = screenFolder,
                DataRoot = Path.Combine(_directory, _prefix, number)
            });
        }

        public async Task SaveCookies(string cookieDir, string cookiesJson,string number) 
        {
           var filePath = Path.Combine(cookieDir, number+".json");
           await File.WriteAllTextAsync(filePath, cookiesJson);
        }    

        public async Task<string> ReadCookies(string number,string cookieDir)
        {
           return await File.ReadAllTextAsync(Path.Combine(cookieDir, number + ".json"));
        }

        public async Task CleanBuild()
        {
            string buildDirectory = Path.Combine(_webHostEnvironment.ContentRootPath, _configuration["subrutaChromiun"]);
            Directory.Delete(buildDirectory,true);
            await Task.CompletedTask;
        }
    }
}
