using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsappScrapper.DataAccess.Context;
using WhatsappScrapper.DataAccess.Migrations.UserDB;
using WhatsAppScrapper.Models.DataModels;

namespace WhatsappScrapper.DataAccess.Repositories
{
    public interface IZoneRepository
    {
        Task<int> AddZone(Zone zone);
        Task<IEnumerable<Zone>> GetZones(string userId);
        Task<int> RemoveZone(string userId, int zoneId);
        Task<List<Zone>> RemoveBulk(string userId,List<int> zoneIds);
    }
    public class ZoneRepository : IZoneRepository
    {
        private UserDBContext _userDBContext;

        private ILogger<ZoneRepository> _logger;

        public ZoneRepository(UserDBContext userDBContext, ILogger<ZoneRepository> logger)
        {
            _userDBContext = userDBContext;
            _logger = logger;
        }
        public async Task<int> AddZone(Zone zone)
        {
            EntityEntry<Zone> savedZone;
            if (zone.Id > 0)
                savedZone = _userDBContext.Zones.Update(zone);
            else
                savedZone = await _userDBContext.Zones.AddAsync(zone);
            await _userDBContext.SaveChangesAsync();

            return savedZone.Entity.Id;
        }

        public async Task<IEnumerable<Zone>> GetZones(string userId)
        {
            return await _userDBContext.Zones.Where(z => z.UserId == userId).ToListAsync();
        }
        
        public async Task<int> RemoveZone(string userId, int zoneId)
        {
            var zone = await _userDBContext.Zones.FirstOrDefaultAsync(z => z.Id == zoneId && z.UserId == userId);
            if (zone != null)
                _userDBContext.Remove(zone);
            await _userDBContext.SaveChangesAsync();
            return zoneId;
        }

        public async Task<List<Zone>> RemoveBulk(string userId,List<int> zoneIds)
        {
            var failedZones = new List<Zone>();
            var existingZones = await _userDBContext.Zones
                .Where(z => zoneIds.Contains(z.Id) && z.UserId == userId)
                .ToListAsync();
         
            foreach(var zone in existingZones)
            {
                try
                {
                    //zone.is
                    _userDBContext.Zones.Remove(zone);
                    await _userDBContext.SaveChangesAsync();
                }
                catch(Exception e)
                {
                    _logger.LogError($"Zona {zone.Id}->{e.Message}");
                   failedZones.Add(zone);                    
                }
            }

            return failedZones;
        }

    }
}
