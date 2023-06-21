using Ecommerce_WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_WEB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
