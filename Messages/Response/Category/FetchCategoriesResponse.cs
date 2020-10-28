using BmesRestApi.Messages.DataTransferObjects.Product;
using System.Collections.Generic;

namespace BmesRestApi.Messages.Response.Category
{
    public class FetchCategoriesResponse :ResponseBase
    {
        public int  CategoriesPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; }
        

    }
}
