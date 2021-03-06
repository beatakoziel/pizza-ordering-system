using Slicesy.PizzaOrder.WebApi.Repositories.Interfaces;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public class SizeAndPriceRepository : RepositoryBase<SizeAndPrice>, ISizeAndPriceRepository
    {
        public SizeAndPriceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}