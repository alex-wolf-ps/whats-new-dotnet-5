using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Api.Services;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly OrderService _orderService;

        public OrdersController(ILogger<OrdersController> logger, OrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet("history")]
        public IActionResult Get()
        {
            var orderHistory = _orderService.OrderHistory;

            return Ok(new OrderHistory() { Orders = orderHistory, TotalOrderCount = orderHistory.Count });
        }

        [HttpGet("history-paginated")]
        public IActionResult Get([FromQuery] int startIndex, [FromQuery] int count)
        {
            var totalCount = _orderService.OrderHistory.Count();

            var orderHistory = _orderService.OrderHistory.OrderBy(x => x.Id).Skip(startIndex).Take(count).ToList();

            // Todo
            return Ok(new OrderHistory() { Orders = orderHistory, TotalOrderCount = totalCount });
        }
    }
}
