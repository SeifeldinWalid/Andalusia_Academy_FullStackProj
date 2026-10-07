namespace Full_Stack_Grad_Project.Model
{
    public class CourseSkill
    {
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
    }
}
