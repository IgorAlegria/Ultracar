using Ultracar.Models;

namespace Ultracar.Repository
{
    public interface IProductRepository
    {
        Product AddProduct(Product Product);

        IEnumerable<Product> GetProducts();

        Product UpdateProduct(Product Product);
        
    }
}