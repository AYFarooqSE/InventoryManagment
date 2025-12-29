namespace Inventory_API.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string SKU { get; set; }= string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
