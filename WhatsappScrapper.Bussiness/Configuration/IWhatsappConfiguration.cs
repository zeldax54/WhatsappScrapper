using WhatsAppScrapper.Models;
using WhatsAppScrapper.Models.DataModels;

namespace WhatsappScrapper.Bussiness.Configuration
{
    public interface IWhatsappConfiguration
    {
        public Task Configure(ConfigureParams configureParams);     
        public Task<IEnumerable<RegisterNumber>> ConfigureList();     
        public Task RemoveRegister(RemoveRegisterParams removeRegisterParams);     
        public Task CleanBuild();     
    }
}
