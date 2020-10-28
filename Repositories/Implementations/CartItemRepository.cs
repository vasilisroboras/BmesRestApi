using BmesRestApi.Database;
using BmesRestApi.Models.Cart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories.Implementations
{
    public class CartItemRepository : ICartItemRepository
    {
        private BmesDbContext _context;

        public CartItemRepository(BmesDbContext context)
        {
            _context = context;
        }

        public CartItem FindCartItemById(long id)
        {
            var cartitem = _context.CartItem.Find(id);
            return cartitem;
        }
        public IEnumerable<CartItem> FindCartItemsByCartId(long cartId)
        {
            var cartitems = _context.CartItem.Where(cartitem => cartitem.CartId == cartId).Include(c => c.Product);
            return cartitems;
        }

        public void SaveCartItem(CartItem cartitem)
        {
            _context.CartItem.Add(cartitem);
            _context.SaveChanges();
        }

        public void UpdateCartItem(CartItem cartitem)
        {
            _context.CartItem.Update(cartitem);
            _context.SaveChanges();
        }

        public void DeleteCartItem(CartItem cartitem)
        {
            _context.CartItem.Remove(cartitem);
            _context.SaveChanges();
        }
    }
}
