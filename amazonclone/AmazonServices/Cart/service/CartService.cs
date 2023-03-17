using Cart.Entities;
using Cart.Repository;

namespace Cart.service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository repo;
        public CartService(ICartRepository repo)
        {
            this.repo = repo;
        }
        public bool Insert(CartDetails details)
        {
            return repo.Add(details);
        }
        public List<CartDetails> GetAll()
        {
         return  repo.GetAll();
        }
    }
}
