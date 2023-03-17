using Cart.Entities;
using Microsoft.EntityFrameworkCore;
namespace Cart.Repository
{
    public class CartContext:DbContext
    {
        public CartContext()
        {

        }
        public CartContext(DbContextOptions<CartContext> options) : base(options) { }
        public virtual DbSet<CartDetails> Cart { get; set; }
    }
}
