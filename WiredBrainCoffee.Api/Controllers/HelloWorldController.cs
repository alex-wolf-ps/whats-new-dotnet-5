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
            throw new System.Exception("A problem occured.");

            return Ok("Hello world");
        }
    }
}