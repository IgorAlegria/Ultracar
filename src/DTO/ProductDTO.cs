


namespace Ultracar.DTO 
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int Amount {get; set; }

        public string? Status {get; set;}
    }

    public class ProductDTOInsert
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int Stock {get; set; }

    }
}