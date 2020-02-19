using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Slicesy.PizzaOrder.WebApi.Controllers
{
    [ApiController, Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        /*[HttpGet]
        public IEnumerable<User> Get()
        {
            return null
        }*/
        
        
    }
}