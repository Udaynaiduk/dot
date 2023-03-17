using Carts.Entities;

namespace Carts.service
{
    public interface ICartService
    {
        List<CartDetails> GetAll();
        bool Insert(CartDetails details);
    }
}