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
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Building number is required")]
        public string BuildingNumber { get; set; }

        [Required(ErrorMessage = "Flat number is required")]
        public string FlatNumber { get; set; }
    }
}