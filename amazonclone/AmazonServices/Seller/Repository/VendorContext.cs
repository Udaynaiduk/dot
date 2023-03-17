using Microsoft.EntityFrameworkCore;
using Seller.Entites;

namespace Seller.Repository
{
    public class VendorContext:DbContext
    {
        public VendorContext() { }
        public VendorContext(DbContextOptions<VendorContext> options) : base(options) { }

        public virtual DbSet<Vendor> Vendors { get; set; }

    }
}
