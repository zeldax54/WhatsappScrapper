using Microsoft.Extensions.Logging;
using WhatsappScrapper.DataAccess.Repositories;
using WhatsAppScrapper.Models.DataModels;

namespace Whatsapp.Bussiness.User.Manager
{
    public interface IZoneManager 
    {
        Task<int> AddZone(Zone zone);
        Task<IEnumerable<Zone>> GetZones(string userId);
        Task<int> RemoveZone(string userId, int zoneId);
    }
    public class ZoneManager : IZoneManager
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ILogger<ZoneManager> _logger;
       
        public ZoneManager(IZoneRepository zoneRepository, ILogger<ZoneManager> logger)
        {
            _zoneRepository = zoneRepository;
            _logger = logger;
        }
      
        public async Task<int> AddZone(Zone zone)
        {
            try
            {
                return await _zoneRepository.AddZone(zone);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }         
        }

        public async Task<IEnumerable<Zone>> GetZones(string userId)
        {
            return await _zoneRepository.GetZones(userId);
        }

        public async Task<int> RemoveZone(string userId, int zoneId)
        {
            try
            {
                return await _zoneRepository.RemoveZone(userId,zoneId);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}
