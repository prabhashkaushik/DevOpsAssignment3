using Microsoft.AspNetCore.Mvc;

namespace DevOpsAssignment3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevOpsAssignment3 : Controller
    {
            // GET: api/DevOpsAssignment3/helloworld
            [HttpGet("helloworld")]
            public IActionResult HelloWorld()
            {
                return Ok("Hello, world!");
            }
    }
}
