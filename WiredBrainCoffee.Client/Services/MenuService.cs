using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient http;

        public MenuService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<MenuItem>> GetMenuItems()
        {
            var menuItems = await http.GetFromJsonAsync<MenuItem[]>("menu");
            return menuItems.ToList();
        }

        public List<MenuItem> GetPopularItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "Mocha Latte",
                    Summary = "Half coffee, half treat - the perfect combo."
                },
                new MenuItem()
                {
                    Name = "Raspberry Coffee",
                    Summary = "A fresh blend with a refreshing taste"
                },
                new MenuItem()
                {
                    Name = "Peppermint Hot Chocolate",
                    Summary = "So good, you'll be glad it's cold outside."
                },
                new MenuItem()
                {
                    Name = "Green Tea",
                    Summary = "It's classic for a reason"
                }
            };
        }
    }
}
