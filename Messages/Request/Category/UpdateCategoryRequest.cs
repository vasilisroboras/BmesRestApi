using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Category
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
