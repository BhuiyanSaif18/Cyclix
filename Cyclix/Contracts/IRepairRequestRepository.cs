using Cyclix.Entities;

namespace Cyclix.Contracts
{
    public interface IRepairRequestRepository
    {
        public void SaveRequest(RepairRequest repairRequest);
        public Task<List<RepairRequest>> GetRequests();
    }
}
