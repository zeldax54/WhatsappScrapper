using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    }
    public class ZoneRepository : IZoneRepository
    {
        private UserDBContext _userDBContext;
        public ZoneRepository(UserDBContext userDBContext)
        {
            _userDBContext = userDBContext;
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
    }
}
