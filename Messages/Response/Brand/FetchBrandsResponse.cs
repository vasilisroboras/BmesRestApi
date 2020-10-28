using BmesRestApi.Messages.DataTransferObjects.Product;
using System.Collections.Generic;

namespace BmesRestApi.Messages.Response.Brand
{
    public class FetchBrandsResponse :ResponseBase
    {
        public int BrandsPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<BrandDto> Brands { get; set; }
        

    }
}
