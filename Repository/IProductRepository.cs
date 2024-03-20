using Ultracar.Models;
using Ultracar.DTO;

namespace Ultracar.Repository
{
    public interface IProductRepository
    {
        public ProductDTOInsert AddProduct(Product product);

        IEnumerable<Product> GetProducts();

        public Product UpdateProduct(int Orderid, int ProductId);
        
    }
}