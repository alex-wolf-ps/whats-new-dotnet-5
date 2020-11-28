using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffee.Models
{
    public class OrderHistory
    {
        public List<Order> Orders { get; set; }
        public int TotalOrderCount { get; set; }

        public OrderHistory()
        {
            Orders = new List<Order>();
        }
    }
}
