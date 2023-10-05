using Api.Entities;
using Microsoft.EntityFrameworkCore;
using NbaShop.Api.Entities;

namespace NbaShop.Api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}