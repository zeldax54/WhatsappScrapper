using WhatsAppScrapper.Models;

namespace WhatsappScrapper.Bussiness.Configuration
{
    public interface IWhatsappConfiguration
    {
        public Task Configure(ConfigureParams configureParams);     
    }
}
