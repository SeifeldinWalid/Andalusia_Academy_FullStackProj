namespace Full_Stack_Grad_Project.DTOs
{
    public class CourseDetailsDTO : CourseDto
    {
        public List<SkillDTO> Skills { get; set; } = new();
        public List<ProgramSummaryDTO> Programs { get; set; } = new();
        public List<CourseSummaryDTO> RelatedCourses { get; set; } = new();
    }
}
