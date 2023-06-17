using Cyclix.Models;

namespace Cyclix.Contracts
{
    public interface ICycleBrandRepository
    {
        public Task<List<CycleBrand>> GetCycleBrands();
    }
}
