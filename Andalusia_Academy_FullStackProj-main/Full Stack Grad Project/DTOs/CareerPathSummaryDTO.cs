namespace Full_Stack_Grad_Project.DTOs
{
    public class CareerPathSummaryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int EstimatedMonths { get; set; }
        public int ProgramCount { get; set; }
    }
}
