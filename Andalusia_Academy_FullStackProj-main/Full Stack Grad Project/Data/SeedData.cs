using Full_Stack_Grad_Project.Enums;
using Full_Stack_Grad_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Data
{
    public static class SeedData
    {
        private static readonly DateTime SeedDate = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc);

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Web Development", IsPopular = true },
                new Category { Id = 2, Name = "Data Science & AI", IsPopular = true },
                new Category { Id = 3, Name = "Mobile Development", IsPopular = true },
                new Category { Id = 4, Name = "Cloud & DevOps", IsPopular = false },
                new Category { Id = 5, Name = "Cybersecurity", IsPopular = false },
                new Category { Id = 6, Name = "UI/UX Design", IsPopular = true }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "HTML & CSS" },
                new Skill { Id = 2, Name = "JavaScript" },
                new Skill { Id = 3, Name = "React" },
                new Skill { Id = 4, Name = "C#" },
                new Skill { Id = 5, Name = "ASP.NET Core" },
                new Skill { Id = 6, Name = "SQL" },
                new Skill { Id = 7, Name = "Python" },
                new Skill { Id = 8, Name = "Machine Learning" },
                new Skill { Id = 9, Name = "Data Visualization" },
                new Skill { Id = 10, Name = "Docker" },
                new Skill { Id = 11, Name = "Microsoft Azure" },
                new Skill { Id = 12, Name = "Network Security" },
                new Skill { Id = 13, Name = "Figma" },
                new Skill { Id = 14, Name = "Flutter" },
                new Skill { Id = 15, Name = "Git" },
                new Skill { Id = 16, Name = "TypeScript" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Title = "HTML & CSS Fundamentals",
                    CategoryId = 1,
                    Description = "Build and style your first web pages with semantic HTML, Flexbox, Grid and responsive design.",
                    Price = 49,
                    DurationHours = 12,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 2,
                    Title = "Modern JavaScript (ES6+)",
                    CategoryId = 1,
                    Description = "Master variables, functions, arrays, objects, async/await and the DOM using modern JavaScript.",
                    Price = 59,
                    DurationHours = 18,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 3,
                    Title = "TypeScript Essentials",
                    CategoryId = 1,
                    Description = "Add static typing to your JavaScript projects with types, interfaces, generics and strict mode.",
                    Price = 49,
                    DurationHours = 10,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 4,
                    Title = "React from Zero to Hero",
                    CategoryId = 1,
                    Description = "Build single page applications with components, hooks, routing and API integration in React.",
                    Price = 79,
                    DurationHours = 24,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 5,
                    Title = "C# Programming Fundamentals",
                    CategoryId = 1,
                    Description = "Learn C# syntax, object oriented programming, collections, LINQ and exception handling.",
                    Price = 59,
                    DurationHours = 20,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 6,
                    Title = "Building REST APIs with ASP.NET Core",
                    CategoryId = 1,
                    Description = "Design and build clean REST APIs with controllers, dependency injection, validation and Swagger.",
                    Price = 89,
                    DurationHours = 28,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Hybrid,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 7,
                    Title = "SQL & Relational Databases",
                    CategoryId = 2,
                    Description = "Write SQL queries, design normalized schemas and work with joins, indexes and transactions.",
                    Price = 49,
                    DurationHours = 14,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 8,
                    Title = "Entity Framework Core in Depth",
                    CategoryId = 1,
                    Description = "Map your domain to a database with EF Core: relationships, migrations, queries and performance.",
                    Price = 69,
                    DurationHours = 16,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Advanced,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 9,
                    Title = "Git & GitHub for Teams",
                    CategoryId = 4,
                    Description = "Version control your code, work with branches and pull requests, and collaborate on GitHub.",
                    Price = 0,
                    DurationHours = 6,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 10,
                    Title = "Python for Everyone",
                    CategoryId = 2,
                    Description = "Start programming with Python: data types, control flow, functions, files and modules.",
                    Price = 49,
                    DurationHours = 16,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 11,
                    Title = "Data Analysis with Pandas",
                    CategoryId = 2,
                    Description = "Clean, transform and analyze real datasets using Pandas and NumPy in Jupyter notebooks.",
                    Price = 69,
                    DurationHours = 20,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 12,
                    Title = "Data Visualization with Power BI",
                    CategoryId = 2,
                    Description = "Turn data into interactive dashboards and reports that business teams can act on.",
                    Price = 79,
                    DurationHours = 15,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Onsite,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 13,
                    Title = "Machine Learning Foundations",
                    CategoryId = 2,
                    Description = "Understand supervised and unsupervised learning and build models with scikit-learn.",
                    Price = 99,
                    DurationHours = 30,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 14,
                    Title = "Deep Learning with PyTorch",
                    CategoryId = 2,
                    Description = "Build neural networks for computer vision and NLP using PyTorch.",
                    Price = 129,
                    DurationHours = 32,
                    IsFeatured = false,
                    Status = CourseStatus.ComingSoon,
                    Type = CourseType.Online,
                    Level = CourseLevel.Advanced,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 15,
                    Title = "Flutter Mobile Apps",
                    CategoryId = 3,
                    Description = "Build beautiful cross platform mobile apps for Android and iOS with Flutter and Dart.",
                    Price = 79,
                    DurationHours = 26,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 16,
                    Title = "Advanced Flutter & State Management",
                    CategoryId = 3,
                    Description = "Scale your Flutter apps with Bloc, Riverpod, clean architecture and testing.",
                    Price = 89,
                    DurationHours = 18,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Advanced,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 17,
                    Title = "React Native Crash Course",
                    CategoryId = 3,
                    Description = "Use your React skills to ship native mobile apps with React Native and Expo.",
                    Price = 69,
                    DurationHours = 14,
                    IsFeatured = false,
                    Status = CourseStatus.ComingSoon,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 18,
                    Title = "Docker & Containers",
                    CategoryId = 4,
                    Description = "Package and run applications in containers with Docker, images, volumes and Compose.",
                    Price = 69,
                    DurationHours = 14,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 19,
                    Title = "Azure Cloud Fundamentals",
                    CategoryId = 4,
                    Description = "Learn core cloud concepts and deploy web apps, databases and storage on Microsoft Azure.",
                    Price = 79,
                    DurationHours = 18,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Hybrid,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 20,
                    Title = "CI/CD Pipelines with GitHub Actions",
                    CategoryId = 4,
                    Description = "Automate building, testing and deploying your applications with GitHub Actions.",
                    Price = 59,
                    DurationHours = 10,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 21,
                    Title = "Cybersecurity Essentials",
                    CategoryId = 5,
                    Description = "Understand threats, vulnerabilities, encryption and how to protect systems and networks.",
                    Price = 59,
                    DurationHours = 16,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 22,
                    Title = "Ethical Hacking & Penetration Testing",
                    CategoryId = 5,
                    Description = "Find and exploit vulnerabilities legally using industry tools in hands-on labs.",
                    Price = 149,
                    DurationHours = 36,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Onsite,
                    Level = CourseLevel.Advanced,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 23,
                    Title = "UI/UX Design Principles",
                    CategoryId = 6,
                    Description = "Learn user research, wireframing, visual hierarchy and usability testing.",
                    Price = 49,
                    DurationHours = 12,
                    IsFeatured = true,
                    Status = CourseStatus.Published,
                    Type = CourseType.Online,
                    Level = CourseLevel.Beginner,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 24,
                    Title = "Prototyping with Figma",
                    CategoryId = 6,
                    Description = "Design interactive prototypes and design systems with components and auto layout in Figma.",
                    Price = 59,
                    DurationHours = 10,
                    IsFeatured = false,
                    Status = CourseStatus.Published,
                    Type = CourseType.Recorded,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                },
                new Course
                {
                    Id = 25,
                    Title = "Web Accessibility Basics",
                    CategoryId = 1,
                    Description = "Make your websites usable for everyone by following WCAG guidelines.",
                    Price = 39,
                    DurationHours = 8,
                    IsFeatured = false,
                    Status = CourseStatus.Draft,
                    Type = CourseType.Online,
                    Level = CourseLevel.Intermediate,
                    CreatedAt = SeedDate
                }
            );

            modelBuilder.Entity<CourseSkill>().HasData(
                new CourseSkill { CourseId = 1, SkillId = 1 },
                new CourseSkill { CourseId = 2, SkillId = 2 },
                new CourseSkill { CourseId = 3, SkillId = 16 },
                new CourseSkill { CourseId = 3, SkillId = 2 },
                new CourseSkill { CourseId = 4, SkillId = 3 },
                new CourseSkill { CourseId = 4, SkillId = 2 },
                new CourseSkill { CourseId = 5, SkillId = 4 },
                new CourseSkill { CourseId = 6, SkillId = 5 },
                new CourseSkill { CourseId = 6, SkillId = 4 },
                new CourseSkill { CourseId = 7, SkillId = 6 },
                new CourseSkill { CourseId = 8, SkillId = 5 },
                new CourseSkill { CourseId = 8, SkillId = 6 },
                new CourseSkill { CourseId = 9, SkillId = 15 },
                new CourseSkill { CourseId = 10, SkillId = 7 },
                new CourseSkill { CourseId = 11, SkillId = 7 },
                new CourseSkill { CourseId = 11, SkillId = 9 },
                new CourseSkill { CourseId = 12, SkillId = 9 },
                new CourseSkill { CourseId = 13, SkillId = 8 },
                new CourseSkill { CourseId = 13, SkillId = 7 },
                new CourseSkill { CourseId = 14, SkillId = 8 },
                new CourseSkill { CourseId = 14, SkillId = 7 },
                new CourseSkill { CourseId = 15, SkillId = 14 },
                new CourseSkill { CourseId = 16, SkillId = 14 },
                new CourseSkill { CourseId = 17, SkillId = 3 },
                new CourseSkill { CourseId = 17, SkillId = 2 },
                new CourseSkill { CourseId = 18, SkillId = 10 },
                new CourseSkill { CourseId = 19, SkillId = 11 },
                new CourseSkill { CourseId = 20, SkillId = 15 },
                new CourseSkill { CourseId = 20, SkillId = 10 },
                new CourseSkill { CourseId = 21, SkillId = 12 },
                new CourseSkill { CourseId = 22, SkillId = 12 },
                new CourseSkill { CourseId = 23, SkillId = 13 },
                new CourseSkill { CourseId = 24, SkillId = 13 },
                new CourseSkill { CourseId = 25, SkillId = 1 }
            );

            modelBuilder.Entity<LearningProgram>().HasData(
                new LearningProgram
                {
                    Id = 1,
                    Title = "Front-End Web Development",
                    Level = CourseLevel.Beginner,
                    DurationWeeks = 12,
                    Description = "Go from your first HTML page to production ready React applications."
                },
                new LearningProgram
                {
                    Id = 2,
                    Title = "Back-End Development with .NET",
                    Level = CourseLevel.Intermediate,
                    DurationWeeks = 14,
                    Description = "Build secure, data driven REST APIs with C#, ASP.NET Core, SQL Server and EF Core."
                },
                new LearningProgram
                {
                    Id = 3,
                    Title = "Data Analysis Professional",
                    Level = CourseLevel.Beginner,
                    DurationWeeks = 10,
                    Description = "Collect, clean, analyze and visualize data to answer real business questions."
                },
                new LearningProgram
                {
                    Id = 4,
                    Title = "Machine Learning Engineer Track",
                    Level = CourseLevel.Advanced,
                    DurationWeeks = 16,
                    Description = "Build, train and evaluate machine learning and deep learning models end to end."
                },
                new LearningProgram
                {
                    Id = 5,
                    Title = "Mobile App Development",
                    Level = CourseLevel.Beginner,
                    DurationWeeks = 10,
                    Description = "Design and ship cross platform mobile apps for Android and iOS."
                },
                new LearningProgram
                {
                    Id = 6,
                    Title = "DevOps & Cloud Engineering",
                    Level = CourseLevel.Intermediate,
                    DurationWeeks = 12,
                    Description = "Automate delivery and run applications reliably in containers and the cloud."
                },
                new LearningProgram
                {
                    Id = 7,
                    Title = "Product Design (UI/UX)",
                    Level = CourseLevel.Beginner,
                    DurationWeeks = 8,
                    Description = "Research, design and prototype digital products that users love."
                }
            );

            modelBuilder.Entity<ProgramCourse>().HasData(
                new ProgramCourse { ProgramId = 1, CourseId = 1, Order = 1 },
                new ProgramCourse { ProgramId = 1, CourseId = 2, Order = 2 },
                new ProgramCourse { ProgramId = 1, CourseId = 9, Order = 3 },
                new ProgramCourse { ProgramId = 1, CourseId = 3, Order = 4 },
                new ProgramCourse { ProgramId = 1, CourseId = 4, Order = 5 },

                new ProgramCourse { ProgramId = 2, CourseId = 5, Order = 1 },
                new ProgramCourse { ProgramId = 2, CourseId = 7, Order = 2 },
                new ProgramCourse { ProgramId = 2, CourseId = 9, Order = 3 },
                new ProgramCourse { ProgramId = 2, CourseId = 6, Order = 4 },
                new ProgramCourse { ProgramId = 2, CourseId = 8, Order = 5 },

                new ProgramCourse { ProgramId = 3, CourseId = 10, Order = 1 },
                new ProgramCourse { ProgramId = 3, CourseId = 7, Order = 2 },
                new ProgramCourse { ProgramId = 3, CourseId = 11, Order = 3 },
                new ProgramCourse { ProgramId = 3, CourseId = 12, Order = 4 },

                new ProgramCourse { ProgramId = 4, CourseId = 10, Order = 1 },
                new ProgramCourse { ProgramId = 4, CourseId = 11, Order = 2 },
                new ProgramCourse { ProgramId = 4, CourseId = 13, Order = 3 },
                new ProgramCourse { ProgramId = 4, CourseId = 14, Order = 4 },

                new ProgramCourse { ProgramId = 5, CourseId = 2, Order = 1 },
                new ProgramCourse { ProgramId = 5, CourseId = 15, Order = 2 },
                new ProgramCourse { ProgramId = 5, CourseId = 16, Order = 3 },
                new ProgramCourse { ProgramId = 5, CourseId = 17, Order = 4 },

                new ProgramCourse { ProgramId = 6, CourseId = 9, Order = 1 },
                new ProgramCourse { ProgramId = 6, CourseId = 18, Order = 2 },
                new ProgramCourse { ProgramId = 6, CourseId = 19, Order = 3 },
                new ProgramCourse { ProgramId = 6, CourseId = 20, Order = 4 },

                new ProgramCourse { ProgramId = 7, CourseId = 23, Order = 1 },
                new ProgramCourse { ProgramId = 7, CourseId = 24, Order = 2 },
                new ProgramCourse { ProgramId = 7, CourseId = 1, Order = 3 }
            );

            modelBuilder.Entity<CareerPath>().HasData(
                new CareerPath
                {
                    Id = 1,
                    Title = "Full-Stack Web Developer",
                    EstimatedMonths = 9,
                    Description = "Build complete web applications, from responsive React front ends to .NET APIs and databases."
                },
                new CareerPath
                {
                    Id = 2,
                    Title = "Data Scientist",
                    EstimatedMonths = 8,
                    Description = "Turn raw data into insights and predictions using Python, SQL and machine learning."
                },
                new CareerPath
                {
                    Id = 3,
                    Title = "Mobile Developer",
                    EstimatedMonths = 6,
                    Description = "Create cross platform mobile apps that run on Android and iOS."
                },
                new CareerPath
                {
                    Id = 4,
                    Title = "Cloud & DevOps Engineer",
                    EstimatedMonths = 7,
                    Description = "Automate, deploy and operate applications at scale in the cloud."
                },
                new CareerPath
                {
                    Id = 5,
                    Title = "UI/UX Designer",
                    EstimatedMonths = 4,
                    Description = "Design intuitive and accessible digital experiences from research to prototype."
                },
                new CareerPath
                {
                    Id = 6,
                    Title = "Cybersecurity Analyst",
                    EstimatedMonths = 6,
                    Description = "Protect organizations by finding vulnerabilities and defending systems and networks."
                }
            );

            modelBuilder.Entity<CareerPathProgram>().HasData(
                new CareerPathProgram { CareerPathId = 1, ProgramId = 1, Order = 1 },
                new CareerPathProgram { CareerPathId = 1, ProgramId = 2, Order = 2 },
                new CareerPathProgram { CareerPathId = 2, ProgramId = 3, Order = 1 },
                new CareerPathProgram { CareerPathId = 2, ProgramId = 4, Order = 2 },
                new CareerPathProgram { CareerPathId = 3, ProgramId = 5, Order = 1 },
                new CareerPathProgram { CareerPathId = 4, ProgramId = 6, Order = 1 },
                new CareerPathProgram { CareerPathId = 4, ProgramId = 2, Order = 2 },
                new CareerPathProgram { CareerPathId = 5, ProgramId = 7, Order = 1 },
                new CareerPathProgram { CareerPathId = 5, ProgramId = 1, Order = 2 }
            );

            modelBuilder.Entity<CareerPathSkill>().HasData(
                new CareerPathSkill { CareerPathId = 1, SkillId = 1 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 2 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 3 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 4 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 5 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 6 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 15 },
                new CareerPathSkill { CareerPathId = 1, SkillId = 16 },
                new CareerPathSkill { CareerPathId = 2, SkillId = 6 },
                new CareerPathSkill { CareerPathId = 2, SkillId = 7 },
                new CareerPathSkill { CareerPathId = 2, SkillId = 8 },
                new CareerPathSkill { CareerPathId = 2, SkillId = 9 },
                new CareerPathSkill { CareerPathId = 3, SkillId = 2 },
                new CareerPathSkill { CareerPathId = 3, SkillId = 3 },
                new CareerPathSkill { CareerPathId = 3, SkillId = 14 },
                new CareerPathSkill { CareerPathId = 3, SkillId = 15 },
                new CareerPathSkill { CareerPathId = 4, SkillId = 5 },
                new CareerPathSkill { CareerPathId = 4, SkillId = 10 },
                new CareerPathSkill { CareerPathId = 4, SkillId = 11 },
                new CareerPathSkill { CareerPathId = 4, SkillId = 15 },
                new CareerPathSkill { CareerPathId = 5, SkillId = 1 },
                new CareerPathSkill { CareerPathId = 5, SkillId = 13 },
                new CareerPathSkill { CareerPathId = 6, SkillId = 12 }
            );

            modelBuilder.Entity<Partner>().HasData(
                new Partner { Id = 1, Name = "Microsoft", LogoUrl = string.Empty },
                new Partner { Id = 2, Name = "Google Cloud", LogoUrl = string.Empty },
                new Partner { Id = 3, Name = "AWS Academy", LogoUrl = string.Empty },
                new Partner { Id = 4, Name = "Cisco Networking Academy", LogoUrl = string.Empty },
                new Partner { Id = 5, Name = "ITIDA", LogoUrl = string.Empty }
            );

            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial
                {
                    Id = 1,
                    AuthorName = "Sara Ahmed",
                    Role = "Front-End Developer",
                    Content = "The Front-End program took me from zero to my first job in less than a year. The projects were exactly what interviewers asked about."
                },
                new Testimonial
                {
                    Id = 2,
                    AuthorName = "Omar Khaled",
                    Role = "Data Analyst",
                    Content = "Clear explanations, real datasets and great mentors. The Power BI course alone paid for itself."
                },
                new Testimonial
                {
                    Id = 3,
                    AuthorName = "Mariam Hassan",
                    Role = "Mobile Developer",
                    Content = "I published my first Flutter app on the Play Store while still in the program."
                },
                new Testimonial
                {
                    Id = 4,
                    AuthorName = "Youssef Ali",
                    Role = "Back-End Developer",
                    Content = "The ASP.NET Core and EF Core courses are the most practical .NET content I have found."
                }
            );
        }
    }
}