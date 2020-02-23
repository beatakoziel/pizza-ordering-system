using Slicesy.PizzaOrder.WebApi.Repositories.Interfaces;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public class PizzaRepository : RepositoryBase<Pizza>, IPizzaRepository
    {
        public PizzaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}