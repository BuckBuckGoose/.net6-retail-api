using Microsoft.EntityFrameworkCore;
using Retail.Domain;

namespace Retail.Repository
{
    public class RetailDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RetailDbContext(DbContextOptions<RetailDbContext> options) : base(options)
        {

        }

    }
}
