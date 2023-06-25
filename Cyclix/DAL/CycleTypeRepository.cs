using Cyclix.Contracts;
using Cyclix.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyclix.DAL
{
    public class CycleTypeRepository : ICycleTypeRepository
    {
        private readonly DataContext _context;
        public CycleTypeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CycleType>> GetCycleTypes()
        {
            var cycleTypes = await _context.CycleTypes.ToListAsync();
            return cycleTypes;
        }

        public async Task<List<CycleType>> GetCycleTypesLang(string lang)
        {
            var cycleTypes = await _context.CycleTypes.Where(x=> x.lang == lang).ToListAsync();
            return cycleTypes;
        }
    }
}
