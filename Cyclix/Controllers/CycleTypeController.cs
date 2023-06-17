using Cyclix.Contracts;
using Cyclix.DAL;
using Cyclix.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cyclix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CycleTypeController : ControllerBase
    {
        private readonly ICycleTypeRepository _cycleTypeRepository;
        public CycleTypeController(ICycleTypeRepository cycleTypeRepository)
        {
            _cycleTypeRepository = cycleTypeRepository;
        }
        [HttpGet]
        public async Task<List<CycleType>> Get()
        {
            return await _cycleTypeRepository.GetCycleTypes();
        }
    }
}
