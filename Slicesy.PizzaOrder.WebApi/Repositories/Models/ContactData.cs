using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("ContactData")]
    public class ContactData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string PhoneNumber { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        public string AdditionalInfo { get; set; }
    }
}