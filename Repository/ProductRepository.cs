using Ultracar.Models;


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

     
        public Product AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
           
        }

        public Product UpdateProduct(Product product)
        {
            try
            {
                _context.Products.Update(product);
                _context.SaveChanges();

                return product;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro ao executar");
            }
        }

    }
}