using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Messages.Response.Order
{
    using DataTransferObjects.Order;
    public class GetOrderResponse : ResponseBase
    {
        public OrderDto Order { get; set; }
    }
}
