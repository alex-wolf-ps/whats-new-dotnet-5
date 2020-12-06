using Microsoft.AspNetCore.Mvc;

namespace WiredBrainCoffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public IActionResult GetGreeting()
        {
            return Ok("Hello world");
        }
    }
}