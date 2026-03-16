using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello World Get");
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetName()
        {
            return Ok("My name is Harsh.");
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok("Hello World Post");

        }
    }
}
