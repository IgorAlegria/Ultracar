using Ultracar.Models;
using Ultracar.DTO;


namespace Ultracar.Repository
{
    public class ProductRepository : IProductRepository
    {
        protected readonly IUltracarContext _context;
        public ProductRepository(IUltracarContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _context.Products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }

        }


        public ProductDTOInsert AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return new ProductDTOInsert
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Stock = product.Stock
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }

        }

        public Product UpdateProduct(int Orderid, int ProductId)
        {
            try
            {
                var order = _context.Orders.First(o => o.OrderId == Orderid);
                var stockProduct = _context.Products.First(p => p.ProductId == ProductId);

                var product = from p in _context.Orders
                              from pr in p.Products!
                              where pr.ProductId == ProductId
                              select new ProductDTO
                              {
                                  ProductId = pr.ProductId,
                                  Name = pr.Name,
                                  Amount = pr.Amount,
                                  Status = "OK"
                              };

                order.Products = product.ToList();




                foreach (var orderProduct in order.Products!)
                {
                    if (orderProduct.ProductId == ProductId && orderProduct.Status == "Ok")
                    {
                        var result = new Product
                        {
                            ProductId = ProductId,
                            Name = orderProduct.Name,
                            Stock = stockProduct.Stock - orderProduct.Amount,
                        };

                        _context.Products.Update(result);
                    }

                }

                _context.Orders.Update(order);
                _context.SaveChanges();

                var resultProduct = _context.Products.First(p => p.ProductId == ProductId);

                return resultProduct;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
        }

    }
}