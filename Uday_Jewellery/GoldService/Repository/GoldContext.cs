using GoldService.Entites;
using Microsoft.EntityFrameworkCore;

namespace GoldService.Repository
{
    public class GoldContext:DbContext
    {
        public GoldContext()
        {

        }
      public GoldContext(DbContextOptions<GoldContext> options) :base(options)
        {

        }
        public virtual DbSet<GoldOrnment> GoldOrnments { get; set; }
    }
}
