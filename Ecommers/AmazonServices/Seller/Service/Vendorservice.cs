using Seller.Entites;
using Seller.Repository;

namespace Seller.Service
{
    public class Vendorservice : IVendorservice
    {
        private readonly IVendorrepository repo;
        public Vendorservice(IVendorrepository repo)
        {
            this.repo = repo;
        }

        public bool Add(Vendor vendor)
        {
            return repo.Add(vendor);

        }
        public bool Login(Vendor vendor)
        {
            return repo.Login(vendor);
        }
    }
}
