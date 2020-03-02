using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("CustomPizza")]
    public class CustomPizza : Pizza
    {
        [Range(1, 50, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int NumberOfFreeIngredients { get; set; }

        public virtual ISet<Ingredient> FreeIngredients { get; set; }
    }
}