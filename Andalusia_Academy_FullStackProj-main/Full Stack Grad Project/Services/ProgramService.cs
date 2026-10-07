using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Mapping;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Full_Stack_Grad_Project.Services.Interfaces;

namespace Full_Stack_Grad_Project.Services
{
    public class ProgramService : IProgramService
    {
        private const int RelatedProgramsCount = 3;

        private readonly IProgramRepo _programRepo;

        public ProgramService(IProgramRepo programRepo)
        {
            _programRepo = programRepo;
        }

        public async Task<IEnumerable<ProgramSummaryDTO>> GetAllProgramsAsync()
        {
            var programs = await _programRepo.GetAllProgramsAsync();
            return programs.Select(p => p.ToProgramSummaryDTO());
        }

        public async Task<ProgramDetailsDTO> GetProgramDetailsAsync(int id)
        {
            var program = await _programRepo.GetProgramDetailsAsync(id);
            var relatedPrograms = await _programRepo.GetRelatedProgramsAsync(program, RelatedProgramsCount);

            var programCourses = program.ProgramCourses
                .Where(pc => pc.Course.IsPublic())
                .OrderBy(pc => pc.Order)
                .ToList();

            return new ProgramDetailsDTO
            {
                Id = program.Id,
                Title = program.Title,
                Description = program.Description,
                ImageUrl = program.ImageUrl,
                Level = program.Level,
                DurationWeeks = program.DurationWeeks,
                CourseCount = programCourses.Count,
                TotalHours = programCourses.Sum(pc => pc.Course.DurationHours),
                Courses = programCourses.Select(pc => pc.ToProgramCourseDTO()).ToList(),
                Skills = programCourses
                    .SelectMany(pc => pc.Course.CourseSkills)
                    .Select(cs => cs.Skill)
                    .DistinctBy(s => s.Id)
                    .Select(s => s.ToSkillDTO())
                    .ToList(),
                CareerPaths = program.CareerPathPrograms.Select(cp => cp.CareerPath.ToCareerPathSummaryDTO()).ToList(),
                RelatedPrograms = relatedPrograms.Select(p => p.ToProgramSummaryDTO()).ToList()
            };
        }
    }
}
