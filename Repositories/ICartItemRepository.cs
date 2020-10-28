using BmesRestApi.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories
{
    public interface ICartItemRepository
    {
        CartItem FindCartItemById(long id);

        IEnumerable<CartItem> FindCartItemsByCartId(long cartId);

        void SaveCartItem(CartItem cartitem);
        void UpdateCartItem(CartItem cartitem);
        void DeleteCartItem(CartItem cartitem);
    }
}
