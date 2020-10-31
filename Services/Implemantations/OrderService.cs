using BmesRestApi.Messages;
using BmesRestApi.Messages.Request.Order;
using BmesRestApi.Messages.Response.Order;
using BmesRestApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Services.Implemantations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public GetOrderResponse GetOrder(GetOrderRequest getOrderRequest)
        {
            return new GetOrderResponse();
        }

        public FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest)
        {
            return new FetchOrdersResponse();
        }
    }
}
