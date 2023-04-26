using WhatsappScrapper.Bussiness.FileStorage;
using WhatsAppScrapper.Models;
using WhatsappScrapper.Bussiness.Puppeteer;
using WhatsAppScrapper.Models.DataModels;
using WhatsappScrapper.DataAccess.Repositories;
using WhatsappScrapper.Bussiness.Manage;

namespace WhatsappScrapper.Bussiness.Configuration
{
    public class WhatsappConfiguration : IWhatsappConfiguration
    {  
  
        private readonly IWPuppeteer _wPuppeteer;   
        private readonly IChromiumFileManager _chromiumFileManager;
        private readonly INumberRegistrationRepository _numberRegistrationRepository;
        private readonly IProcessKiller _processKiller;

        public WhatsappConfiguration(IWPuppeteer wPuppeteer, IChromiumFileManager chromiumFileManager,
            INumberRegistrationRepository numberRegistrationRepository, IProcessKiller processKiller) 
        {     
            _wPuppeteer = wPuppeteer;
            _chromiumFileManager = chromiumFileManager;
            _numberRegistrationRepository = numberRegistrationRepository;
            _processKiller = processKiller;
        }

        public Task CleanBuild()
        {
            _chromiumFileManager.CleanBuild();
            return Task.CompletedTask;
        }

        public async Task Configure(ConfigureParams configureParams)
        {            
            await _wPuppeteer.Configure(configureParams.Number, configureParams.WaitforQRTime, configureParams.WaitforEndTime);           
        }

        public async Task<IEnumerable<RegisterNumber>> ConfigureList()
        {
            return await _numberRegistrationRepository.RegisteredNumbers();
        }

        public async Task RemoveRegister(RemoveRegisterParams removeRegisterParams)
        {
            var register = await _numberRegistrationRepository.GetRegisteredById(removeRegisterParams.Id);
            _processKiller.KillProcessByName("Chromium");
            await _wPuppeteer.RemoveConfig(register.SettingsDir);
            await _numberRegistrationRepository.MarkAsInactive(removeRegisterParams.Id);           
        }
    }
}
