using Cyclix.Models;

namespace Cyclix.Contracts
{
    public interface ICycleTypeRepository
    {
        public Task<List<CycleType>> GetCycleTypes();
        
    }
}
