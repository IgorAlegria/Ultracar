namespace Ultracar.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int Stock { get; set; }
    }


}