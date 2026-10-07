namespace Full_Stack_Grad_Project.Model
{
    public class ProgramCourse
    {
        public int ProgramId { get; set; }
        public LearningProgram Program { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int Order { get; set; }
    }
}
