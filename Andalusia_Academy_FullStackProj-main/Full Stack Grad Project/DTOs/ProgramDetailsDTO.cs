namespace Full_Stack_Grad_Project.DTOs
{
    public class ProgramDetailsDTO : ProgramSummaryDTO
    {
        public int TotalHours { get; set; }
        public List<ProgramCourseDTO> Courses { get; set; } = new();
        public List<SkillDTO> Skills { get; set; } = new();
        public List<CareerPathSummaryDTO> CareerPaths { get; set; } = new();
        public List<ProgramSummaryDTO> RelatedPrograms { get; set; } = new();
    }
}
