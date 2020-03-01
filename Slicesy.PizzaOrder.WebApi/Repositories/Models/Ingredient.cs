using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Ingredient name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Prices are required")]
        public virtual ISet<SizeAndPrice> Prices { get; set; }
    }
}