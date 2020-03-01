using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Slicesy.PizzaOrder.WebApi.Repositories.Models.Enums;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Pizza name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Pizza availability info is required")]
        public bool Available { get; set; }
        
        [Required(ErrorMessage = "Pizzeria is required")]
        public virtual Pizzeria Pizzeria { get; set; }
        
        [Required(ErrorMessage = "Pizza type is required")]
        public virtual PizzaType PizzaType { get; set; }
        
        public virtual ISet<Ingredient> AdditionalIngredients { get; set; }
        
        [Required(ErrorMessage = "Prices are required")]
        public virtual ISet<SizeAndPrice> Prices { get; set; }
    }
}