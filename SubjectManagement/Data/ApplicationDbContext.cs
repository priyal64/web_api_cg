using Microsoft.EntityFrameworkCore;
using SubManagement.Models;

namespace SubManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<SubTopic> Subtopics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>()
                .HasOne(t => t.Subject)
                .WithMany(s => s.Topics)
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubTopic>()
                .HasOne(s => s.Topic)
                .WithMany(t => t.Subtopics)
                .HasForeignKey(s => s.TopicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}