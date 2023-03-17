using Items.Entites;
using Microsoft.EntityFrameworkCore;

namespace Items.Repository
{
    public class ItemsContext:DbContext
    {
        public ItemsContext() { }
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options) { }

        public virtual DbSet<ItemDetails> Items{ get; set; }

    }
}
