using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient http;

        public OrderService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<OrderHistory> GetOrders()
        {
            var orders = await http.GetFromJsonAsync<OrderHistory>("orders/history");
            return orders;
        }

        public async Task<OrderHistory> GetPaginatedOrders(int startIndex, int count)
        {
            var orders = await http.GetFromJsonAsync<OrderHistory>($"orders/history-paginated?startIndex={startIndex}&count={count}");
            return orders;
        }
    }
}
