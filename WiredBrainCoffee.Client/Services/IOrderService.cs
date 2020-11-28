using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public interface IOrderService
    {
        Task<OrderHistory> GetOrders();
        Task<OrderHistory> GetPaginatedOrders(int startIndex, int count);
    }
}