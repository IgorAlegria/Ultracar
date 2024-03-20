namespace Ultracar.DTO 
{
    public class OrderDTO
    {
        public int OrderNumber { get; set; }
        public string? LicensePlate { get; set; }
        public string? ClientName { get; set; }
        public List<ProductDTO>? Products { get; set; }
    }

    public class InsertProductIntoOrderDTO
    {
        public int ProductId { get; set; }

        public int Amount {get; set; }

        public string Status {get; set;} = "pending";
    }
}