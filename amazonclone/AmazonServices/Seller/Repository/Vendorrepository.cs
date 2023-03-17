using Seller.Entites;

namespace Seller.Repository
{
    public class Vendorrepository : IVendorrepository
    {
        private readonly VendorContext vendorContextvendorContext;
        public Vendorrepository(VendorContext vendorContext)
        {
            this.vendorContextvendorContext = vendorContext;
        }
        public bool Add(Vendor vendor)
        {
            try
            {
                vendorContextvendorContext.Add(vendor);
                vendorContextvendorContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Login(Vendor vendor)
        {
            Vendor found = vendorContextvendorContext.Vendors.Find(vendor.Email);
            if (found != null)
            {
                if (found.Password == vendor.Password)
                {
                    return true;
                }

            }
            return false;
        }


    }
}
