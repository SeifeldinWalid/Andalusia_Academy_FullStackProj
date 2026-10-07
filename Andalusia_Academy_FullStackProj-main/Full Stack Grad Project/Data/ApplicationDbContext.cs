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
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProgramCourse> ProgramCourses { get; set; }
        public DbSet<CareerPathProgram> CareerPathPrograms { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }
        public DbSet<CareerPathSkill> CareerPathSkills { get; set; }

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
                entity.Property(e => e.Status).HasConversion<string>().HasMaxLength(20);
                entity.Property(e => e.Type).HasConversion<string>().HasMaxLength(20);
                entity.Property(e => e.Level).HasConversion<string>().HasMaxLength(20);
            });

            modelBuilder.Entity<LearningProgram>(entity =>
            {
                entity.Property(e => e.Level).HasConversion<string>().HasMaxLength(20);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<ProgramCourse>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.CourseId });
                entity.HasOne(e => e.Program).WithMany(p => p.ProgramCourses).HasForeignKey(e => e.ProgramId);
                entity.HasOne(e => e.Course).WithMany(c => c.ProgramCourses).HasForeignKey(e => e.CourseId);
            });

            modelBuilder.Entity<CareerPathProgram>(entity =>
            {
                entity.HasKey(e => new { e.CareerPathId, e.ProgramId });
                entity.HasOne(e => e.CareerPath).WithMany(c => c.CareerPathPrograms).HasForeignKey(e => e.CareerPathId);
                entity.HasOne(e => e.Program).WithMany(p => p.CareerPathPrograms).HasForeignKey(e => e.ProgramId);
            });

            modelBuilder.Entity<CourseSkill>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.SkillId });
                entity.HasOne(e => e.Course).WithMany(c => c.CourseSkills).HasForeignKey(e => e.CourseId);
                entity.HasOne(e => e.Skill).WithMany(s => s.CourseSkills).HasForeignKey(e => e.SkillId);
            });

            modelBuilder.Entity<CareerPathSkill>(entity =>
            {
                entity.HasKey(e => new { e.CareerPathId, e.SkillId });
                entity.HasOne(e => e.CareerPath).WithMany(c => c.CareerPathSkills).HasForeignKey(e => e.CareerPathId);
                entity.HasOne(e => e.Skill).WithMany(s => s.CareerPathSkills).HasForeignKey(e => e.SkillId);
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

            modelBuilder.Seed();
        }
    }
}
