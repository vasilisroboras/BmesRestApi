namespace BmesRestApi.Messages.Request.Category
{
    public class FetchCategoriesRequest
    {
        public int PageNumber { get; set; }
        public int BrandsPerPage { get; set; }
    }
}
