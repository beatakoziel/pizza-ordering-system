using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Pizza is required")]
        public virtual Pizza Pizza { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public virtual Company Company { get; set; }

        public virtual ISet<OrderPosition> OrderPositions { get; set; }

        public virtual ISet<OrderState> OrderStates { get; set; }
    }
}