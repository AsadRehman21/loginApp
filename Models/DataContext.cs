using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace loginApp.Models
{
    public class DataContext:IdentityDbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}