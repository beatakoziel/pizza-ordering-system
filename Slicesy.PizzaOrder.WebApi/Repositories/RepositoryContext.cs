using Microsoft.EntityFrameworkCore;
using Slicesy.PizzaOrder.WebApi.Repositories.Models;

namespace Slicesy.PizzaOrder.WebApi.Repositories
{
    public sealed class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<ContactData> ContactData { get; set; }

        public DbSet<Company> Companies { get; set; }
    }
}