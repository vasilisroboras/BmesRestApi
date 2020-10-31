using BmesRestApi.Models.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Models.Customer
{
    using Address;
    using Order;
    public class Customer:BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Order {get ; set;}
        public IEnumerable<Address> Addresses { get; set; }
    }
}
