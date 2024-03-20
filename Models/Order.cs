namespace Ultracar.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Ultracar.DTO;

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? LicensePlate { get; set; }
        public string? ClientName { get; set; }

        [ForeignKey("ProductId")]

        public int ProductId { get; set; }

        public List<ProductDTO>? Products { get; set; }
    }
}
