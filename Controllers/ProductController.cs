using Microsoft.AspNetCore.Mvc;
using Ultracar.Repository;
using Ultracar.DTO;
using Ultracar.Models;

namespace Ultracar.Controllers;

[ApiController]
[Route("Product")]
public class ProductController : Controller
{
    private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
  
    [HttpGet]
        public IActionResult GetProducts()
        {
            var response = _repository.GetProducts();
            return Ok(response);
        }

     [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
        
            ProductDTOInsert newOrder = _repository.AddProduct(product);
            return Created("", newOrder);
            
        }

        [HttpPut("{OrderId}/{ProductId}")]
        public IActionResult PutCity(int OrderId, int ProductId)
        {
             var updateStock = _repository.UpdateStock(OrderId, ProductId);
        
            return Ok(updateStock);
        
        }
}