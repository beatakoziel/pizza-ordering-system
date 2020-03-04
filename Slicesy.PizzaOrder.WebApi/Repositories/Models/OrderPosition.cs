using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    public class OrderPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Order is required")]
        public virtual Order Order { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        public virtual Employee Employee { get; set; }

        [Range(1, 8, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required(ErrorMessage = "NumberOfSlices is required")]
        public int NumberOfSlices { get; set; }
    }
}