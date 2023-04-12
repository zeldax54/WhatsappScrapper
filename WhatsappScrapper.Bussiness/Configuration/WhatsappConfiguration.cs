using WhatsappScrapper.Bussiness.FileStorage;
using WhatsAppScrapper.Models;
using WhatsappScrapper.Bussiness.Puppeteer;

namespace WhatsappScrapper.Bussiness.Configuration
{
    public class WhatsappConfiguration : IWhatsappConfiguration
    {  
  
        private readonly IWPuppeteer _wPuppeteer;   
        
        public WhatsappConfiguration(IWPuppeteer wPuppeteer) 
        {     
            _wPuppeteer = wPuppeteer;
        }
        public async Task Configure(ConfigureParams configureParams)
        {            
            await _wPuppeteer.Configure(configureParams.Number);           
        }     
    }
}
