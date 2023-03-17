using Carts.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Carts.Repository
{
    
    public class CartRepository : ICartRepository
    {
        private readonly CartContext cartContext;
        public CartRepository(CartContext cartContext)
        {
            this.cartContext = cartContext;
        }
        public bool Add(CartDetails Cart)
        {
            try
            {
                cartContext.Add(Cart);
                cartContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public List<CartDetails> GetAll()
        {
            return cartContext.Cart.ToList();
        }
    }
}
