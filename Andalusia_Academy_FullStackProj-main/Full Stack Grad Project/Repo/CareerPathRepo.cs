using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Exceptions;
using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Repo
{
    public class CareerPathRepo : ICareerPathRepo
    {
        private readonly ApplicationDbContext _context;

        public CareerPathRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CareerPath>> GetAllCareerPathsAsync()
        {
            return await _context.CareerPaths
                .Include(c => c.CareerPathPrograms)
                .OrderBy(c => c.Id)
                .ToListAsync();
        }

        public async Task<CareerPath> GetCareerPathDetailsAsync(int id)
        {
            var careerPath = await _context.CareerPaths
                .Include(c => c.CareerPathSkills).ThenInclude(cs => cs.Skill)
                .Include(c => c.CareerPathPrograms).ThenInclude(cp => cp.Program)
                    .ThenInclude(p => p.ProgramCourses).ThenInclude(pc => pc.Course).ThenInclude(c => c.Category)
                .AsSplitQuery()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (careerPath != null)
            {
                return careerPath;
            }
            throw new NotFoundException("Career Path Not Found");
        }
    }
}
