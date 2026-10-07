namespace Full_Stack_Grad_Project.DTOs
{
    public class CareerPathDetailsDTO : CareerPathSummaryDTO
    {
        public List<SkillDTO> Skills { get; set; } = new();
        public List<ProgramSummaryDTO> Programs { get; set; } = new();
        public List<CourseSummaryDTO> RecommendedCourses { get; set; } = new();
    }
}
