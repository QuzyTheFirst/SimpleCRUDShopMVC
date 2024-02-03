using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopMVC.Models
{
    public class OrdersIndexVM
    {
        public int Id { get; set; }
        public Order.StatusEnum Status { get; set; }
        [DisplayName("Client Name")]
        public string ClientName { get; set; }
        [DisplayName("Product Title")]
        public string ProductTitle { get; set; }
        [DisplayName("Product Quantity")]
        public int ProductQuantity { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Order Full Price")]
        public decimal OrderFullPrice { get; set; }
    }
}
