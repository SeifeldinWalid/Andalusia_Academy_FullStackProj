namespace Full_Stack_Grad_Project.Pagination
{
    public class PaginationParam
    {
        private const int _maxPageSize = 100;

        private int _page = 1;

        private int _pageSize = 20;

        public int Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value < 1 ? 1 : value;
            }
        }

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value > _maxPageSize ? _maxPageSize : value < 1 ? 1 : value;
            }
        }
    }
}
