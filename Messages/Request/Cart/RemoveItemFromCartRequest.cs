using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Messages.Request.Cart
{
    public class RemoveItemFromCartRequest
    {
        public long CartId { get; set; }
        public long CartItemId { get; set; }
    }
}
