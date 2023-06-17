using AutoMapper;
using Cyclix.Contracts;
using Cyclix.DTOs;
using Cyclix.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cyclix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepairRequestController : Controller
    {
        private readonly IRepairRequestRepository _repairRequestRepository;
        private readonly IMapper  _mapper;
        public RepairRequestController(IRepairRequestRepository repairRequestRepository,
            IMapper mapper)
        {
            _repairRequestRepository = repairRequestRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult StoreRequst([FromBody] RepairRequestDto repairRequest)
        {
            var repairReq = _mapper.Map<RepairRequest>(repairRequest);
            _repairRequestRepository.SaveRequest(repairReq);
            return StatusCode(201);
        }
        [HttpGet]
        public Task<List<RepairRequest>> GetRequests()
        {
            return _repairRequestRepository.GetRequests();
        }
    }
}
