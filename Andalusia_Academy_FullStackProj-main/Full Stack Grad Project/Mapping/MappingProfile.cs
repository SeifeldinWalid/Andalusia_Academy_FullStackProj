using AutoMapper;
using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Course (CategoryName is flattened automatically from Category.Name)
            CreateMap<Course, CourseDto>();
            CreateMap<Course, CourseSummaryDTO>();

            CreateMap<Course, CourseDetailsDTO>()
                .IncludeBase<Course, CourseDto>()
                .ForMember(d => d.Skills, o => o.MapFrom(s => s.CourseSkills.Select(cs => cs.Skill)))
                .ForMember(d => d.Programs, o => o.MapFrom(s => s.ProgramCourses.Select(pc => pc.Program)))
                .ForMember(d => d.RelatedCourses, o => o.Ignore());

            // ProgramCourse -> course fields from the Course, Order from the join row
            CreateMap<Course, ProgramCourseDTO>()
                .ForMember(d => d.Order, o => o.Ignore());
            CreateMap<ProgramCourse, ProgramCourseDTO>()
                .IncludeMembers(pc => pc.Course);

            CreateMap<Skill, SkillDTO>();

            // Learning programs
            CreateMap<LearningProgram, ProgramSummaryDTO>()
                .ForMember(d => d.CourseCount, o => o.MapFrom(s => s.ProgramCourses.Count));

            // Courses, Skills, TotalHours and CourseCount only count public courses, so the service fills them in
            CreateMap<LearningProgram, ProgramDetailsDTO>()
                .IncludeBase<LearningProgram, ProgramSummaryDTO>()
                .ForMember(d => d.CourseCount, o => o.Ignore())
                .ForMember(d => d.TotalHours, o => o.Ignore())
                .ForMember(d => d.Courses, o => o.Ignore())
                .ForMember(d => d.Skills, o => o.Ignore())
                .ForMember(d => d.CareerPaths, o => o.MapFrom(s => s.CareerPathPrograms.Select(cp => cp.CareerPath)))
                .ForMember(d => d.RelatedPrograms, o => o.Ignore());

            // Career paths
            CreateMap<CareerPath, CareerPathSummaryDTO>()
                .ForMember(d => d.ProgramCount, o => o.MapFrom(s => s.CareerPathPrograms.Count));

            // Programs and RecommendedCourses are ordered/filtered, so the service fills them in
            CreateMap<CareerPath, CareerPathDetailsDTO>()
                .IncludeBase<CareerPath, CareerPathSummaryDTO>()
                .ForMember(d => d.Skills, o => o.MapFrom(s => s.CareerPathSkills.Select(cs => cs.Skill)))
                .ForMember(d => d.Programs, o => o.Ignore())
                .ForMember(d => d.RecommendedCourses, o => o.Ignore());

            // Categories & homepage CMS
            CreateMap<Category, CategoryDTO>()
                .ForMember(d => d.CourseCount, o => o.MapFrom(s => s.Courses.Count));

            CreateMap<Partner, PartnerDTO>();
            CreateMap<Testimonial, TestimonialDTO>();

            CreateMap<HomepageContent, HomepageDTO>()
                .ForMember(d => d.FeaturedCourses, o => o.Ignore())
                .ForMember(d => d.PopularCategories, o => o.Ignore())
                .ForMember(d => d.Partners, o => o.Ignore())
                .ForMember(d => d.Testimonials, o => o.Ignore());
        }
    }
}
