using Carts.Entities;

namespace Carts.Repository
{
    public interface ICartRepository
    {
        bool Add(CartDetails Cart);
        List<CartDetails> GetAll();
    }
}