using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Contact data is required")]
        public virtual ContactData ContactData { get; set; }

        [Required(ErrorMessage = "Company address is required")]
        public virtual Address CompanyAddress { get; set; }

        [Required(ErrorMessage = "Delivery address is required")]
        public virtual Address DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Register code is required")]
        [StringLength(20, MinimumLength = 20, ErrorMessage = "Register code must have {0} characters")]
        public string RegisterCode { get; set; }

        //TODO
        //public virtual ISet<Employee> Employees { get; set; }
        //public virtual ISet<Order> Orders { get; set; }
    }
}