using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Extras Extras { get; set; }
    }
}
