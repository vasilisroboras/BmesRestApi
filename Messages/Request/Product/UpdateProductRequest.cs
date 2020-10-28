using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
    }
}
