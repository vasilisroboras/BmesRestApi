using BmesRestApi.Messages.Request.Cart;
using BmesRestApi.Messages.Response.Cart;
using BmesRestApi.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Services
{
    public interface ICartService
    {
        AddItemToCartResponse AddItemToCart(AddItemToCartRequest addItemToCartRequest);
        RemoveItemFromCartResponse RemoveItemFromCart(RemoveItemFromCartRequest removeItemFromCartRequest);
        string UniqueCartId();
        Cart GetCart();

        FetchCartResponse FetchCart();

        IEnumerable<CartItem> GetCartItems();

        int CartItemsCount();

        decimal GetCartTotal();
    }
}
