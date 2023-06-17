using Cyclix.Contracts;
using Cyclix.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cyclix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly ICycleBrandRepository _cycleBrandRepository;
        public BrandController(ICycleBrandRepository cycleBrandRepository)
        {
            _cycleBrandRepository = cycleBrandRepository;
        }
        [HttpGet]
        public async Task<List<CycleBrand>> Get()
        {
            return await _cycleBrandRepository.GetCycleBrands();
        }
    }
}
