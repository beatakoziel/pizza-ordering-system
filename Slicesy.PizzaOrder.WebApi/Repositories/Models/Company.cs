using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Contact data is required")]
        [ForeignKey("CompanyContactDataFK")]
        public virtual ContactData ContactData { get; set; }

        [Required(ErrorMessage = "Company address is required")]
        [ForeignKey("CompanyAddressFK")]
        public virtual Address CompanyAddress { get; set; }

        [Required(ErrorMessage = "Delivery address is required")]
        [ForeignKey("CompanyDeliveryAddressFK")]
        public virtual Address DeliveryAddress { get; set; }

        //TODO
        //public virtual ISet<Employee> Employees { get; set; }
        //public virtual ISet<Order> Orders { get; set; }
    }
}