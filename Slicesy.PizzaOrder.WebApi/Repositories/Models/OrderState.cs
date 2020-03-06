using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Slicesy.PizzaOrder.WebApi.Repositories.Models.Enums;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    public class OrderState
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "StateType is required")]
        public OrderStateType StateType { get; set; }

        [Required(ErrorMessage = "ChangeDate is required")]
        public DateTime ChangeDate { get; set; }

        public virtual ISet<OrderPosition> OrderPositions { get; set; }
    }
}