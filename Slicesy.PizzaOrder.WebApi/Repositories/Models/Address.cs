using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }
        
        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { set; get; }
        
        [Required(ErrorMessage = "City is required")]
        public string City { set; get; }
        
        [Required(ErrorMessage = "Street is required")]
        public string Street { set; get; }
        
        [Required(ErrorMessage = "Building number is required")]
        public string BuildingNumber { set; get; }
        
        [Required(ErrorMessage = "Flat number is required")]
        public string FlatNumber { set; get; }
    }
}