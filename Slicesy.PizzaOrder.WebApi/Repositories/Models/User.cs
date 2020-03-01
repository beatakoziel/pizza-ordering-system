using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Slicesy.PizzaOrder.WebApi.Repositories.Models.Enums;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table("PizzaUser")]
    public class User
    {
        public User(string login, string password, long? permittedResourceId = null)
        {
            Login = login;
            Password = password;
            PermittedResourceId = permittedResourceId;
            Active = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Active info is required")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Pizzeria or company id is required")]
        public long? PermittedResourceId { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public UserRole Role { get; set; }
    }
}