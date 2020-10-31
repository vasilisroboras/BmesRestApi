using BmesRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Models.Order
{
    using Address;
    using Customer;
    public class Order:BaseObject
    {
        
        public decimal OrderTotal { get; set; }
        public decimal OrderItemTotal { get; set; }
        public decimal ShippingCharge { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public long AddressId { get; set; }
        public Address DeliveryAddress  { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        
    }
}
