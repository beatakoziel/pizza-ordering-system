using Slicesy.PizzaOrder.WebApi.Repositories.Interfaces;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}