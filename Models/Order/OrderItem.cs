using BmesRestApi.Models.Shared;
using BmesRestApi.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BmesRestApi.Models.Order
{
    using BmesRestApi.Models.Product;
    public class OrderItem:BaseObject
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
