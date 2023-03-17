using Seller.Entites;

namespace Seller.Repository
{
    public interface IVendorrepository
    {
        bool Add(Vendor vendor);
        bool Login(Vendor vendor);
    }
}