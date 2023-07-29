using Microsoft.EntityFrameworkCore;
using YatishChaudhari.Models;

namespace YatishChaudhari.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
