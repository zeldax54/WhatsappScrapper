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
           var savedZone =  await _userDBContext.Zones.AddAsync(zone);
           await  _userDBContext.SaveChangesAsync();
           return savedZone.Entity.Id;
        }
    }
}
