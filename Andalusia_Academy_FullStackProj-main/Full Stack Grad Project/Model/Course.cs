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
        
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        
        public int? ProgramId { get; set; }
        public LearningProgram? Program { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
