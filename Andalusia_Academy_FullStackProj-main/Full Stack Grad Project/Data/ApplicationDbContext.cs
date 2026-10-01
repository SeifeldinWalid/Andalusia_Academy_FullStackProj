using Full_Stack_Grad_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningProgram> Programs { get; set; }
        public DbSet<CareerPath> CareerPaths { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HomepageContent> HomepageContents { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Example of fluent API configuration if needed
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });
            
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasData(
                    new Role { Id = 1, Name = "Admin" },
                    new Role { Id = 2, Name = "Instructor" },
                    new Role { Id = 3, Name = "Learner" },
                    new Role { Id = 4, Name = "Content Manager" }
                );
            });

            modelBuilder.Entity<HomepageContent>(entity =>
            {
                entity.HasData(new HomepageContent
                {
                    Id = 1,
                    HeroTitle = "Welcome to Andalusia Academy",
                    HeroSubtitle = "Learn the most demanded skills",
                    CorporateTitle = "For Business",
                    CorporateDescription = "Upskill your team with our tailored corporate training programs.",
                    ComingSoonText = "New courses are launching next month!"
                });
            });
        }
    }
}
