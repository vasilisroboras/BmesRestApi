using BmesRestApi.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories
{
    public interface IOrderItemRepository
    {
        OrderItem FindOrderItemById(long id);
        IEnumerable<OrderItem> FindOrderItemByOrderId(long orderId);
        IEnumerable<OrderItem> GetAllOrderItems();
        void SaveOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(OrderItem orderItem);
    }
}
