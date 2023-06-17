using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Cyclix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepairRequestController : Controller
    {
        [HttpPost]
        public IActionResult StoreRequst()
        {
            return StatusCode(201);
        }
    }
}
