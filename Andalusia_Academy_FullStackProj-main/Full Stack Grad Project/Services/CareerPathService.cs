using AutoMapper;
using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Repo.Interfaces;
using Full_Stack_Grad_Project.Services.Interfaces;

namespace Full_Stack_Grad_Project.Services
{
    public class CareerPathService : ICareerPathService
    {
        private const int ExtraSkillCoursesCount = 6;

        private readonly ICareerPathRepo _careerPathRepo;
        private readonly ICourseRepo _courseRepo;
        private readonly IMapper _mapper;

        public CareerPathService(ICareerPathRepo careerPathRepo, ICourseRepo courseRepo, IMapper mapper)
        {
            _careerPathRepo = careerPathRepo;
            _courseRepo = courseRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CareerPathSummaryDTO>> GetAllCareerPathsAsync()
        {
            var careerPaths = await _careerPathRepo.GetAllCareerPathsAsync();
            return _mapper.Map<IEnumerable<CareerPathSummaryDTO>>(careerPaths);
        }

        public async Task<CareerPathDetailsDTO> GetCareerPathDetailsAsync(int id)
        {
            var careerPath = await _careerPathRepo.GetCareerPathDetailsAsync(id);

            var programs = careerPath.CareerPathPrograms
                .OrderBy(cp => cp.Order)
                .Select(cp => cp.Program)
                .ToList();

            // Recommended courses = the courses of the path's programs (in order),
            // plus other courses that teach the path's skills
            var programCourses = programs
                .SelectMany(p => p.ProgramCourses.OrderBy(pc => pc.Order).Select(pc => pc.Course))
                .Where(c => c.IsPublic())
                .DistinctBy(c => c.Id)
                .ToList();

            var skillIds = careerPath.CareerPathSkills.Select(cs => cs.SkillId).ToList();
            var programCourseIds = programCourses.Select(c => c.Id).ToList();
            var skillCourses = await _courseRepo.GetCoursesBySkillsAsync(skillIds, programCourseIds, ExtraSkillCoursesCount);

            var dto = _mapper.Map<CareerPathDetailsDTO>(careerPath);
            dto.Programs = _mapper.Map<List<ProgramSummaryDTO>>(programs);
            dto.RecommendedCourses = _mapper.Map<List<CourseSummaryDTO>>(programCourses.Concat(skillCourses));
            return dto;
        }
    }
}
