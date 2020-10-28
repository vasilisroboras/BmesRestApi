using BmesRestApi.Messages.Request.Product;
using BmesRestApi.Messages.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Services
{
    public interface ICatalogueService
    {
        FetchProductsResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}
