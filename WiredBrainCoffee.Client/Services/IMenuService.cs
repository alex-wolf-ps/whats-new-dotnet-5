using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public interface IMenuService
    {
        Task<List<MenuItem>> GetMenuItems();

        List<MenuItem> GetPopularItems();
    }
}
