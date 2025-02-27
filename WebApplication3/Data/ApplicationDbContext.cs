using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;
namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Marks> Marks { get; set; }


    }
}
