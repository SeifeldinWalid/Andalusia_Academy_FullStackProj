using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Repo.Interfaces
{
    public interface ICourseRepo
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<IEnumerable<Course>> GetFeaturedCoursesAsync();
        Task<Course?> GetCourseByIdAsync(int id);
    }
}
