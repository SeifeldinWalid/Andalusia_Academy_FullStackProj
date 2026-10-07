using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Pagination
{
    public class CourseFilterParam : PaginationParam
    {
        public string? Search { get; set; }

        public int? CategoryId { get; set; }

        public int? SkillId { get; set; }

        public CourseStatus? Status { get; set; }

        public CourseType? Type { get; set; }

        public CourseLevel? Level { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }

        public string? SortBy { get; set; }

        public string? Order { get; set; } = "asc";
    }
}
