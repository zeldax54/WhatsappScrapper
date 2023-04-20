using WhatsappScrapper.DataAccess.Context;
using WhatsAppScrapper.Models.DataModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WhatsappScrapper.DataAccess.Repositories
{
    public interface INumberRegistrationRepository
    {
        Task Create(RegisterNumber registerNumber);
        Task MarkAsInactive(int id);
        Task<IEnumerable<RegisterNumber>> RegisteredNumbers();
    }

    public class NumberRegistrationRepository : INumberRegistrationRepository
    {
        private readonly WhatsappDBContext _context;
        public NumberRegistrationRepository(WhatsappDBContext context)
        {
            _context = context;
        }

        public async Task Create(RegisterNumber registerNumber)
        {
            await _context.RegisterNumbers.AddAsync(registerNumber);            
        }

        public async Task MarkAsInactive(int id)
        {
            var registerNumber = await _context.RegisterNumbers.FirstAsync(r=>r.Id == id);
            registerNumber.IsActive = false;
            _context.Update(registerNumber);
        }

        public async Task<IEnumerable<RegisterNumber>> RegisteredNumbers()
        {
           return await _context.RegisterNumbers.ToListAsync();
        }
    }
}
