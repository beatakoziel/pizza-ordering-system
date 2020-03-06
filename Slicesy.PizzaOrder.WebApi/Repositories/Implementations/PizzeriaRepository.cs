using Slicesy.PizzaOrder.WebApi.Repositories.Interfaces;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public class PizzeriaRepository : RepositoryBase<Pizzeria>, IPizzeriaRepository
    {
        public PizzeriaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}