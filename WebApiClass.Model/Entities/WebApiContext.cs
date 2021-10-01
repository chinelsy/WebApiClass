using Microsoft.EntityFrameworkCore;

namespace WebApiClass.Model.Entities
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions options)
            : base(options)
        {         
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
