using Microsoft.AspNetCore.Mvc;
using Ultracar.Repository;
using Ultracar.DTO;
using Ultracar.Models;

namespace Ultracar.Controllers;

[ApiController]
[Route("Order")]
public class OrderController : Controller
{
    private readonly IOrderRepository _repository;
        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }
  
    [HttpGet]
        public IActionResult GetOrders()
        {
            var response = _repository.GetOrders();
            return Ok(response);
        }

     [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
        
            OrderDTO newOrder = _repository.AddOrder(order);
            return Created("", newOrder);
            
        }

        [HttpPut("{OrderId}")]
        public IActionResult PutCity(int OrderId, [FromBody] InsertProductIntoOrderDTO product)
        {
             var updateOrder = _repository.InsertProductsOrder(OrderId, product);
        
            return Ok(updateOrder);
        
        }
}
