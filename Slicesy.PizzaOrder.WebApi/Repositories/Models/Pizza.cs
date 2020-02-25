<<<<<<< Updated upstream
=======
using System;
using System.Collections.Generic;
>>>>>>> Stashed changes
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        // add relation for pizzeria
        [Required(ErrorMessage = "Pizzeria id is required")]
        public long PizzeriaId { get; set; }

        [Required(ErrorMessage = "Pizza name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingredients is required")]
        public string Ingredients { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Price per slice is required")]
        public decimal PricePerSlice { get; set; }
<<<<<<< Updated upstream
=======

        public ISet<Tuple<string, decimal>> SizeAndPrice { get; set; }
>>>>>>> Stashed changes
    }
}