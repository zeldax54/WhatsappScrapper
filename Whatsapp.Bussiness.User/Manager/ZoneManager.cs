using WhatsappScrapper.DataAccess.Repositories;
using WhatsAppScrapper.Models.DataModels;

namespace Whatsapp.Bussiness.User.Manager
{
    public interface IZoneManager 
    {
        Task<int> AddZone(Zone zone);
    }
    public class ZoneManager : IZoneManager
    {
        private readonly IZoneRepository _zoneRepository;
       
        public ZoneManager(IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
        }
      
        public async Task<int> AddZone(Zone zone)
        {
          return await _zoneRepository.AddZone(zone);
        } 
        
    }
}
