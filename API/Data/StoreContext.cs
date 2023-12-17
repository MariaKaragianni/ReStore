using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) //the base class is DbContext
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}