using BmesRestApi.Database;
using BmesRestApi.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories.Implementations
{
    public class CartRepository : ICartRepository
    {
        private BmesDbContext _context;

        public CartRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Cart FindCartById(long id)
        {
            var cart = _context.Cart.Find(id);
            return cart;
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            var carts = _context.Cart;
            return carts;
        }

        public void SaveCart(Cart cart)
        {
            _context.Cart.Add(cart);
            _context.SaveChanges(); 
        }

        public void UpdateCart(Cart cart)
        {
            
            _context.Cart.Update(cart);
            _context.SaveChanges();
        }

        public void DeleteCart(Cart cart)
        {
            _context.Cart.Remove(cart);
            _context.SaveChanges();
        }
    }
}
