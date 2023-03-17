using Cart.Entities;

namespace Cart.Repository
{
    public interface ICartRepository
    {
        bool Add(CartDetails Cart);
        List<CartDetails> GetAll();
    }
}