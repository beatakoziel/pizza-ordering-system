using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Postal code must have {0} characters")]
        public string PostalCode { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required(ErrorMessage = "Building number is required")]
        public string BuildingNumber { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required(ErrorMessage = "Flat number is required")]
        public string FlatNumber { get; set; }
    }
}