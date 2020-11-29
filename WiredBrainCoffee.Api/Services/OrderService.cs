using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Api.Services
{
    public class OrderService
    {
        public List<Order> OrderHistory { get; set; }

        public OrderService()
        {
            OrderHistory = GenerateOrders();
        }

        private List<Order> GenerateOrders()
        {
            var generatedOrders = new List<Order>();

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
                generatedOrders.Add(new Order()
                {
                    Id = i,
                    Created = DateTime.Now,
                    OrderNumber = rnd.Next(1000, 10000),
                    PromoCode = "None",
                    Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                    Items = new List<OrderItem>() { new OrderItem() { Id = 1, Name = sampleItems[rnd.Next(0, 9)], Price = 5 } }
                });
            }

            return generatedOrders;
        }
    }
}
