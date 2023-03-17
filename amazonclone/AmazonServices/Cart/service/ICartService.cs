using Cart.Entities;

namespace Cart.service
{
    public interface ICartService
    {
        bool Insert(CartDetails details);
        List<CartDetails> GetAll();
    }
}