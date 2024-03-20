using Ultracar.Models;

namespace Ultracar.Repository
{
    public interface IOrderRepository
    {
        Order AddOrder(Order order);

        IEnumerable<Order> GetOrders();

        Order UpdateOrder(Order order);
        
    }
}