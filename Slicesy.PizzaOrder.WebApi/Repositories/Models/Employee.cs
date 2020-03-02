using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "User is required")]
        public virtual User User { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public virtual Company Company { get; set; }
    }
}