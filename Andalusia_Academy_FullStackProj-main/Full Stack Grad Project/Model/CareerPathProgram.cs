namespace Full_Stack_Grad_Project.Model
{
    public class CareerPathProgram
    {
        public int CareerPathId { get; set; }
        public CareerPath CareerPath { get; set; } = null!;

        public int ProgramId { get; set; }
        public LearningProgram Program { get; set; } = null!;

        public int Order { get; set; }
    }
}
