using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Exceptions;
using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Pagination;
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

        // Draft and Archived courses are hidden from the public catalog
        public IQueryable<Course> PublicCourses()
        {
            return _context.Courses
                .Include(c => c.Category)
                .Where(c => c.Status == CourseStatus.Published || c.Status == CourseStatus.ComingSoon);
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await PublicCourses().OrderBy(c => c.Id).ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetFeaturedCoursesAsync()
        {
            return await PublicCourses().Where(c => c.IsFeatured).ToListAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await PublicCourses().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Course> GetCourseDetailsAsync(int id)
        {
            var course = await PublicCourses()
                .Include(c => c.CourseSkills).ThenInclude(cs => cs.Skill)
                .Include(c => c.ProgramCourses).ThenInclude(pc => pc.Program).ThenInclude(p => p.ProgramCourses)
                .AsSplitQuery()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course != null)
            {
                return course;
            }
            throw new NotFoundException("Course Not Found");
        }

        public async Task<IEnumerable<Course>> GetRelatedCoursesAsync(Course course, int count)
        {
            var skillIds = course.CourseSkills.Select(cs => cs.SkillId).ToList();

            return await PublicCourses()
                .Where(c => c.Id != course.Id)
                .Where(c => c.CategoryId == course.CategoryId || c.CourseSkills.Any(cs => skillIds.Contains(cs.SkillId)))
                .OrderByDescending(c => c.CourseSkills.Count(cs => skillIds.Contains(cs.SkillId)))
                .ThenBy(c => c.Id)
                .Take(count)
                .ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetCoursesBySkillsAsync(List<int> skillIds, List<int> excludedCourseIds, int count)
        {
            return await PublicCourses()
                .Where(c => !excludedCourseIds.Contains(c.Id))
                .Where(c => c.CourseSkills.Any(cs => skillIds.Contains(cs.SkillId)))
                .OrderByDescending(c => c.CourseSkills.Count(cs => skillIds.Contains(cs.SkillId)))
                .ThenBy(c => c.Id)
                .Take(count)
                .ToListAsync();
        }

        public async Task<(IEnumerable<Course> Items, int TotalCount)> SearchCoursesAsync(CourseFilterParam filter)
        {
            var query = PublicCourses();

            if (!string.IsNullOrWhiteSpace(filter.Search))
            {
                var term = filter.Search.Trim();
                query = query.Where(c => c.Title.Contains(term) || c.Description.Contains(term));
            }

            if (filter.CategoryId.HasValue)
            {
                query = query.Where(c => c.CategoryId == filter.CategoryId.Value);
            }

            if (filter.SkillId.HasValue)
            {
                query = query.Where(c => c.CourseSkills.Any(cs => cs.SkillId == filter.SkillId.Value));
            }

            if (filter.Status.HasValue)
            {
                query = query.Where(c => c.Status == filter.Status.Value);
            }

            if (filter.Type.HasValue)
            {
                query = query.Where(c => c.Type == filter.Type.Value);
            }

            if (filter.Level.HasValue)
            {
                query = query.Where(c => c.Level == filter.Level.Value);
            }

            if (filter.MinPrice.HasValue)
            {
                query = query.Where(c => c.Price >= filter.MinPrice.Value);
            }

            if (filter.MaxPrice.HasValue)
            {
                query = query.Where(c => c.Price <= filter.MaxPrice.Value);
            }

            var descending = string.Equals(filter.Order, "desc", StringComparison.OrdinalIgnoreCase);

            query = filter.SortBy?.ToLower() switch
            {
                "title" => descending ? query.OrderByDescending(c => c.Title) : query.OrderBy(c => c.Title),
                "price" => descending ? query.OrderByDescending(c => c.Price) : query.OrderBy(c => c.Price),
                "duration" => descending ? query.OrderByDescending(c => c.DurationHours) : query.OrderBy(c => c.DurationHours),
                "createdat" => descending ? query.OrderByDescending(c => c.CreatedAt) : query.OrderBy(c => c.CreatedAt),
                _ => descending ? query.OrderByDescending(c => c.Id) : query.OrderBy(c => c.Id)
            };

            var totalCount = await query.CountAsync();

            var items = await query
                .Skip((filter.Page - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToListAsync();

            return (items, totalCount);
        }
    }
}
