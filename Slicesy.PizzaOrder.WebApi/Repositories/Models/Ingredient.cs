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
        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prices are required")]
        [Range(typeof(decimal), "0.00", "999.99", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public virtual ISet<SizeAndPrice> Prices { get; set; }
    }
}