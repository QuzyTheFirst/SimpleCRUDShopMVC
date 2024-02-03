using System.ComponentModel.DataAnnotations;

namespace ShopMVC.Models
{
    public class Client
    {
        public enum GenderEnum
        {
            Male,
            Female
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        public GenderEnum Gender { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
