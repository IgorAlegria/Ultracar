using Ultracar.Models;


namespace Ultracar.Repository
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly IUltracarContext _context;
        public OrderRepository(IUltracarContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            try
            {
                return _context.Orders;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
        
        }

     
        public Order AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return order;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
           
        }

        public Order UpdateOrder(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                _context.SaveChanges();

                return order;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
        }

    }
}