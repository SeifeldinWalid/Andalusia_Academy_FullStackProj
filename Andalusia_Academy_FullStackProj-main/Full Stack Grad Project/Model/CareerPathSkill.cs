namespace Full_Stack_Grad_Project.Model
{
    public class CareerPathSkill
    {
        public int CareerPathId { get; set; }
        public CareerPath CareerPath { get; set; } = null!;

        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
    }
}
