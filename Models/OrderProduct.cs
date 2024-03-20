namespace Ultracar.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class OrderProduct
    {
        public int OrderId { get; set; }
         public int ProductId { get; set; }
      

        public Order? Order { get; set; }

        public Product? Product { get; set; } 
    }
}
