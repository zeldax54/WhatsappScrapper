using WhatsappScrapper.Bussiness.FileStorage;
using WhatsAppScrapper.Models;
using WhatsappScrapper.Bussiness.Puppeteer;

namespace WhatsappScrapper.Bussiness.Configuration
{
    public class WhatsappConfiguration : IWhatsappConfiguration
    {  
  
        private readonly IWPuppeteer _wPuppeteer;   
        private readonly IChromiumFileManager _chromiumFileManager;
        
        public WhatsappConfiguration(IWPuppeteer wPuppeteer, IChromiumFileManager chromiumFileManager) 
        {     
            _wPuppeteer = wPuppeteer;
            _chromiumFileManager = chromiumFileManager;
        }

        public Task CleanBuild()
        {
            _chromiumFileManager.CleanBuild();
            return Task.CompletedTask;
        }

        public async Task Configure(ConfigureParams configureParams)
        {            
            await _wPuppeteer.Configure(configureParams.Number);           
        }     
    }
}
