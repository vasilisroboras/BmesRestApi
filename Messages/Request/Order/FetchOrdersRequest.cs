using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Messages.Request.Order
{
    public class FetchOrdersRequest
    {
        public int PageNumber { get; set; }
        public int OrdersPerPage { get; set; }
    }
}
