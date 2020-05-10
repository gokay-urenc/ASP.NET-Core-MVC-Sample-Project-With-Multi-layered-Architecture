using System.ComponentModel.DataAnnotations;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        [Required(ErrorMessage = "The First name is required.")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Minimum character lenght must be 10.")]
        public string Address { get; set; }

        [Required]
        [Range(18, 65)]
        public int Age { get; set; }
    }
}