using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Mapping
{
    public static class CatalogMapper
    {
        public static bool IsPublic(this Course course)
        {
            return course.Status == CourseStatus.Published || course.Status == CourseStatus.ComingSoon;
        }

        public static CourseDto ToCourseDto(this Course course)
        {
            return new CourseDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                ImageUrl = course.ImageUrl,
                Price = course.Price,
                DurationHours = course.DurationHours,
                Status = course.Status,
                Type = course.Type,
                Level = course.Level,
                CategoryId = course.CategoryId,
                CategoryName = course.Category?.Name
            };
        }

        public static CourseSummaryDTO ToCourseSummaryDTO(this Course course)
        {
            return new CourseSummaryDTO
            {
                Id = course.Id,
                Title = course.Title,
                ImageUrl = course.ImageUrl,
                Price = course.Price,
                DurationHours = course.DurationHours,
                Status = course.Status,
                Type = course.Type,
                Level = course.Level,
                CategoryName = course.Category?.Name
            };
        }

        public static ProgramCourseDTO ToProgramCourseDTO(this ProgramCourse programCourse)
        {
            var course = programCourse.Course;
            return new ProgramCourseDTO
            {
                Order = programCourse.Order,
                Id = course.Id,
                Title = course.Title,
                ImageUrl = course.ImageUrl,
                Price = course.Price,
                DurationHours = course.DurationHours,
                Status = course.Status,
                Type = course.Type,
                Level = course.Level,
                CategoryName = course.Category?.Name
            };
        }

        public static SkillDTO ToSkillDTO(this Skill skill)
        {
            return new SkillDTO
            {
                Id = skill.Id,
                Name = skill.Name
            };
        }

        public static ProgramSummaryDTO ToProgramSummaryDTO(this LearningProgram program)
        {
            return new ProgramSummaryDTO
            {
                Id = program.Id,
                Title = program.Title,
                Description = program.Description,
                ImageUrl = program.ImageUrl,
                Level = program.Level,
                DurationWeeks = program.DurationWeeks,
                CourseCount = program.ProgramCourses.Count
            };
        }

        public static CareerPathSummaryDTO ToCareerPathSummaryDTO(this CareerPath careerPath)
        {
            return new CareerPathSummaryDTO
            {
                Id = careerPath.Id,
                Title = careerPath.Title,
                Description = careerPath.Description,
                ImageUrl = careerPath.ImageUrl,
                EstimatedMonths = careerPath.EstimatedMonths,
                ProgramCount = careerPath.CareerPathPrograms.Count
            };
        }
    }
}
