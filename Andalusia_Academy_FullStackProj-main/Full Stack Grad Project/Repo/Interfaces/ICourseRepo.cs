using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Pagination;

namespace Full_Stack_Grad_Project.Repo.Interfaces
{
    public interface ICourseRepo
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<IEnumerable<Course>> GetFeaturedCoursesAsync();
        Task<Course?> GetCourseByIdAsync(int id);
        Task<Course> GetCourseDetailsAsync(int id);
        Task<IEnumerable<Course>> GetRelatedCoursesAsync(Course course, int count);
        Task<IEnumerable<Course>> GetCoursesBySkillsAsync(List<int> skillIds, List<int> excludedCourseIds, int count);
        Task<(IEnumerable<Course> Items, int TotalCount)> SearchCoursesAsync(CourseFilterParam filter);
    }
}
