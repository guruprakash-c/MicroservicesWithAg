using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int StockQuantity { get; set; }
    }
}
