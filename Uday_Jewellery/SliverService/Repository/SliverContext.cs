using Microsoft.EntityFrameworkCore;
using SliverService.Entites;

namespace SliverService.Repository
{
    public class SliverContext:DbContext

    {

        public SliverContext() { }

        public SliverContext(DbContextOptions<SliverContext> options): base(options) { }

        public virtual DbSet<SliverOrnment> SliverOrnments { get; set; }
    }
}
