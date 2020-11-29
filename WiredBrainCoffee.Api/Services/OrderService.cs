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

            var sampleLorem = new List<string>()
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                "Ut posuere fringilla ipsum ac eleifend.",
                "Quisque malesuada purus non justo viverra tristique.",
                "Vestibulum vestibulum laoreet magna sed tempor.",
                "Duis tempus auctor tellus, vitae accumsan lectus blandit vitae.",
                "Etiam et erat eu massa accumsan dignissim nec nec neque.",
                "Vivamus consequat dui vel pellentesque malesuada.",
                "Fusce tincidunt ante et dolor posuere pellentesque.",
                "Praesent vehicula condimentum nunc. Etiam mattis non quam ut eleifend.",
                "Pellentesque habitant morbi tristique senectus et netus"
            };

            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                generatedOrders.Add(new Order()
                {
                    Id = i,
                    Created = DateTime.Now.AddHours(rnd.Next(1,4)).AddDays(rnd.Next(1, 20)),
                    OrderNumber = rnd.Next(1000, 10000),
                    PromoCode = "None",
                    Notes = sampleLorem[rnd.Next(0, 9)],
                    Items = new List<OrderItem>() { new OrderItem() { Id = 1, Name = sampleItems[rnd.Next(0, 9)], Price = 5 } }
                });
            }

            return generatedOrders;
        }
    }
}
