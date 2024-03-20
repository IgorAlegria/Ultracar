using Ultracar.Models;
using Ultracar.DTO;

namespace Ultracar.Repository
{
    public interface IOrderRepository
    {
        OrderDTO AddOrder(Order order);

        IEnumerable<Order> GetOrders();

        Order InsertProductsOrder(int OrderId, InsertProductIntoOrderDTO product);
        
    }
}