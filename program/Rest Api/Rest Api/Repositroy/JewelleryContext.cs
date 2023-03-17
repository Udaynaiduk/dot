using Microsoft.EntityFrameworkCore;
using Rest_Api.Entites;

namespace Rest_Api.Repositroy

{
    public class JewelleryContext : DbContext

    {
        public JewelleryContext() { }
        public JewelleryContext(DbContextOptions<JewelleryContext> Options) : base(Options) { }

        public virtual DbSet<GoldOrnment> GoldOrnments { get; set; }
        public virtual DbSet<SliverOrnment> SliverOrnments { get; set; }

    }
}
