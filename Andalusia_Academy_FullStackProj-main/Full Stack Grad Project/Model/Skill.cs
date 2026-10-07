namespace Full_Stack_Grad_Project.Model
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<CourseSkill> CourseSkills { get; set; } = new List<CourseSkill>();
        public ICollection<CareerPathSkill> CareerPathSkills { get; set; } = new List<CareerPathSkill>();
    }
}
