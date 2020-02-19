using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Models
{
    [Table(("PizzaUser"))]
    public class User
    {
        public User(string login, string password, long? permittedResourceId = null)
        {
            Login = login;
            Password = password;
            PermittedResourceId = permittedResourceId;
            Active = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }
        
        [Required(ErrorMessage = "Login is required")]
        public string Login { set; get; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        public bool Active { get; set; }
        
        public long? PermittedResourceId { get; set; }
    }
}