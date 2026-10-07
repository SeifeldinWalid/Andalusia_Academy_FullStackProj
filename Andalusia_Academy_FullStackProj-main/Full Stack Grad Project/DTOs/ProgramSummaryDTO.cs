using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.DTOs
{
    public class ProgramSummaryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public CourseLevel Level { get; set; }
        public int DurationWeeks { get; set; }
        public int CourseCount { get; set; }
    }
}
