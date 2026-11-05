namespace NShop.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ShortDesc { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }
}