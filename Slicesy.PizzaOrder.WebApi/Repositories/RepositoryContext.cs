using Microsoft.EntityFrameworkCore;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories
{
    public sealed class RepositoryContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}