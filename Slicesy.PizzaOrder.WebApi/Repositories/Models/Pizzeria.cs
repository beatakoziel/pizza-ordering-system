using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Pizzeria")]
    public class Pizzeria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Description { get; set; }
        
        [Required(ErrorMessage = "Address is required")]
        public virtual Address Address { get; set; }
        
        [Required(ErrorMessage = "Contact data is required")]
        public virtual ContactData ContactData { get; set; }
    }
}