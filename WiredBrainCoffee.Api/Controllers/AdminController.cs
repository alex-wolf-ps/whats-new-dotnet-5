using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/order-history")]
        public IActionResult Get()
        {
            var orderHistory = new List<Order>();

            var sampleItems = new List<string>()
            {
                "Latte",
                "Cappucino",
                "Cookies",
                "Coffee",
                "Cupcake",
                "Fuit Cup",
                "Bagel",
                "Granola",
                "Americano",
                "Pumpkin Bread"
            };

            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                orderHistory.Add(new Order()
                {
                    Created = DateTime.Now,
                    OrderNumber = rnd.Next(1000, 10000),
                    PromoCode = "None",
                    Items = new List<OrderItem>() { new OrderItem() { Name = sampleItems[rnd.Next(0, 9)] } }
                });
            }

            // Todo
            return Ok(orderHistory);
        }
    }
}
