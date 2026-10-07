using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Exceptions;
using Full_Stack_Grad_Project.Model;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Repo
{
    public class ProgramRepo : IProgramRepo
    {
        private readonly ApplicationDbContext _context;

        public ProgramRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LearningProgram>> GetAllProgramsAsync()
        {
            return await _context.Programs
                .Include(p => p.ProgramCourses)
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<LearningProgram> GetProgramDetailsAsync(int id)
        {
            var program = await _context.Programs
                .Include(p => p.ProgramCourses).ThenInclude(pc => pc.Course).ThenInclude(c => c.Category)
                .Include(p => p.ProgramCourses).ThenInclude(pc => pc.Course).ThenInclude(c => c.CourseSkills).ThenInclude(cs => cs.Skill)
                .Include(p => p.CareerPathPrograms).ThenInclude(cp => cp.CareerPath).ThenInclude(c => c.CareerPathPrograms)
                .AsSplitQuery()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (program != null)
            {
                return program;
            }
            throw new NotFoundException("Program Not Found");
        }

        public async Task<IEnumerable<LearningProgram>> GetRelatedProgramsAsync(LearningProgram program, int count)
        {
            var careerPathIds = program.CareerPathPrograms.Select(cp => cp.CareerPathId).ToList();
            var courseIds = program.ProgramCourses.Select(pc => pc.CourseId).ToList();

            return await _context.Programs
                .Include(p => p.ProgramCourses)
                .Where(p => p.Id != program.Id)
                .Where(p => p.CareerPathPrograms.Any(cp => careerPathIds.Contains(cp.CareerPathId))
                         || p.ProgramCourses.Any(pc => courseIds.Contains(pc.CourseId)))
                .OrderBy(p => p.Id)
                .Take(count)
                .ToListAsync();
        }
    }
}
