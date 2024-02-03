using System.ComponentModel.DataAnnotations;

namespace ShopMVC.Models
{
    public class Order
    {
        public enum StatusEnum
        {
            Created,
            Paid,
            Delivered,
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public StatusEnum Status { get; set; }

        public Client? Client { get; set; }
        public Product? Product { get; set; }
    }
}
