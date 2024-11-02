using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("helloworld")] 
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }
    }
}
