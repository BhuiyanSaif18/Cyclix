using Cyclix.Contracts;
using Cyclix.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyclix.DAL
{
    public class CycleBrandRepository : ICycleBrandRepository
    {
        private readonly DataContext _context;
        public CycleBrandRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CycleBrand>> GetCycleBrands()
        {
            var cycleBrands = await _context.CycleBrands.ToListAsync();
            return cycleBrands;
        }
    }
}
