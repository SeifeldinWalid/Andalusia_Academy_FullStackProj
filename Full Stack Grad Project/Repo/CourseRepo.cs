using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Repo
{
    public class CourseRepo : ICourseRepo
    {
        private readonly ApplicationDbContext _context;

        public CourseRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses.Include(c => c.Category).ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetFeaturedCoursesAsync()
        {
            return await _context.Courses.Include(c => c.Category).Where(c => c.IsFeatured).ToListAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await _context.Courses.Include(c => c.Category).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
