namespace Full_Stack_Grad_Project.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsPopular { get; set; }
        
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
} 
