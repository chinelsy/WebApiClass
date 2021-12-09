using Microsoft.EntityFrameworkCore;
using WebApiClass.Model.DataSeeding;

namespace WebApiClass.Model.Entities
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions options)
            : base(options)
        {         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerSeeding());
            modelBuilder.ApplyConfiguration(new AccountSeeding());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
