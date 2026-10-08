using Full_Stack_Grad_Project.Enums;

namespace Full_Stack_Grad_Project.Model
{
    public class LearningProgram
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public CourseLevel Level { get; set; } = CourseLevel.Beginner;
        public int DurationWeeks { get; set; }
        
        public ICollection<ProgramCourse> ProgramCourses { get; set; } = new List<ProgramCourse>();
        public ICollection<CareerPathProgram> CareerPathPrograms { get; set; } = new List<CareerPathProgram>();
    }
}
