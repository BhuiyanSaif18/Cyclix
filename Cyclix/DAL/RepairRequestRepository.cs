using Cyclix.Contracts;
using Cyclix.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cyclix.DAL
{
    public class RepairRequestRepository : IRepairRequestRepository
    {
        private readonly DataContext _context;
        public RepairRequestRepository(DataContext context)
        {
            _context = context;
        }

        public void SaveRequest(RepairRequest repairRequest)
        {
            _context.RepairRequests.Add(repairRequest);
            _context.SaveChanges();
        }

        public async Task<List<RepairRequest>> GetRequests()
        {
            var requests = await _context.RepairRequests.ToListAsync();
            return requests;
        }
    }
}
