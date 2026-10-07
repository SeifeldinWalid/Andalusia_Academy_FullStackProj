namespace Full_Stack_Grad_Project.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; } 
        public bool IsFeatured { get; set; }
        public int DurationHours { get; set; }

        public CourseStatus Status { get; set; } = CourseStatus.Draft;
        public CourseType Type { get; set; } = CourseType.Online;
        public CourseLevel Level { get; set; } = CourseLevel.Beginner;
        
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        
        public ICollection<ProgramCourse> ProgramCourses { get; set; } = new List<ProgramCourse>();
        public ICollection<CourseSkill> CourseSkills { get; set; } = new List<CourseSkill>();
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
