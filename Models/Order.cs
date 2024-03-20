namespace Ultracar.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? LicensePlate { get; set; }
        public string? ClientName { get; set; }

        [ForeignKey("ProductId")]

        public int ProductId { get; set; }

        public ICollection<Product> Products { get; set; } = null!;
    }
}
