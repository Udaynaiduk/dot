using Seller.Entites;

namespace Seller.Service
{
    public interface IVendorservice
    {
        bool Add(Vendor vendor);
        bool Login(Vendor vendor);
    }
}