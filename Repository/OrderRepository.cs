using Ultracar.Models;
using Ultracar.DTO;


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

     
        public OrderDTO AddOrder(Order order)
        {
            try
            {
             
                _context.Orders.Add(order);
                _context.SaveChanges();
                return new OrderDTO
                {
                    OrderNumber = order.OrderId,
                    LicensePlate = order.LicensePlate,
                    ClientName = order.ClientName,
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
           
        }

        public Order InsertProductsOrder(int OrderId, InsertProductIntoOrderDTO product)
        {
            try
            {
                   var order = _context.Orders.FirstOrDefault(o => o.OrderId == OrderId)!;
                   var selectProduct = _context.Products.FirstOrDefault(o => o.ProductId == product.ProductId)!;

                   var insertProducts = new ProductDTO {
                        ProductId = product.ProductId,
                        Name = selectProduct.Name,
                        Amount = product.Amount,
                        Status = "Pending"
                    };

                order!.Products!.Add(insertProducts);
              
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