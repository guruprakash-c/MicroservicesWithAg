using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class ProductDbContextClass : DbContext
    {
        protected readonly IConfiguration _config;
        public ProductDbContextClass(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Products> Products { get; set; }
    }
}
