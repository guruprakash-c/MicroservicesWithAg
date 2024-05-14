using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Data
{
    public class CustomerDbContextClass : DbContext
    {
        protected readonly IConfiguration _config;
        public CustomerDbContextClass(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Customers> Customers { get; set; }
    }
}
