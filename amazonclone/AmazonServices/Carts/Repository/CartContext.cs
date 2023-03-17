using Carts.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carts.Repository
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
