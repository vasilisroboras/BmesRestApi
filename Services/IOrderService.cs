using BmesRestApi.Messages.Request.Order;
using BmesRestApi.Messages.Response.Order;
using BmesRestApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Services
{
    public interface IOrderService
    {
        GetOrderResponse GetOrder(GetOrderRequest getOrderRequest);


        FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest);
        
    }
}
