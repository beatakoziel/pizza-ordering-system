using Slicesy.PizzaOrder.WebApi.Repositories.Interfaces;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public class ContactDataRepository : RepositoryBase<ContactData>, IContactDataRepository
    {
        public ContactDataRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}