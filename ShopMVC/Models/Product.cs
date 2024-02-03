using System.ComponentModel.DataAnnotations;

namespace ShopMVC.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required, DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
