using Cart.Entities;

namespace Cart.Repository
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
            catch
            {
                return false;
            }
        }
        public List<CartDetails> GetAll()
        {
            return cartContext.Cart.ToList();
        }
    }
}
