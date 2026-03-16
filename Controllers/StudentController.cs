using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello World");
        }
    }
}
