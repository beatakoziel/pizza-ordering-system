using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Slicesy.PizzaOrder.WebApi.Repositories.Models.Enums;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("CustomPizza")]
    public class CustomPizza : Pizza
    {
        public int NumberOfFreeIngredients { get; set; }
        
        public virtual ISet<Ingredient> FreeIngredients { get; set; }
    }
}