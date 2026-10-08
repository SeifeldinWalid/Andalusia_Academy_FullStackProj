using AutoMapper;
using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Full_Stack_Grad_Project.Services.Interfaces;

namespace Full_Stack_Grad_Project.Services
{
    public class ProgramService : IProgramService
    {
        private const int RelatedProgramsCount = 3;

        private readonly IProgramRepo _programRepo;
        private readonly IMapper _mapper;

        public ProgramService(IProgramRepo programRepo, IMapper mapper)
        {
            _programRepo = programRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProgramSummaryDTO>> GetAllProgramsAsync()
        {
            var programs = await _programRepo.GetAllProgramsAsync();
            return _mapper.Map<IEnumerable<ProgramSummaryDTO>>(programs);
        }

        public async Task<ProgramDetailsDTO> GetProgramDetailsAsync(int id)
        {
            var program = await _programRepo.GetProgramDetailsAsync(id);
            var relatedPrograms = await _programRepo.GetRelatedProgramsAsync(program, RelatedProgramsCount);

            var programCourses = program.ProgramCourses
                .Where(pc => pc.Course.IsPublic())
                .OrderBy(pc => pc.Order)
                .ToList();

            var skills = programCourses
                .SelectMany(pc => pc.Course.CourseSkills)
                .Select(cs => cs.Skill)
                .DistinctBy(s => s.Id);

            var dto = _mapper.Map<ProgramDetailsDTO>(program);
            dto.CourseCount = programCourses.Count;
            dto.TotalHours = programCourses.Sum(pc => pc.Course.DurationHours);
            dto.Courses = _mapper.Map<List<ProgramCourseDTO>>(programCourses);
            dto.Skills = _mapper.Map<List<SkillDTO>>(skills);
            dto.RelatedPrograms = _mapper.Map<List<ProgramSummaryDTO>>(relatedPrograms);
            return dto;
        }
    }
}
