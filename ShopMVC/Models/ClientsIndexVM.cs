using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopMVC.Models
{
    public class ClientsIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Client.GenderEnum Gender { get; set; }
        [DisplayName("Number of orders")]
        public int OrdersCount { get; set; }
        [DisplayName("Orders Average Price"), DataType(DataType.Currency)]
        public decimal OrdersAveragePrice { get; set; }
    }
}
