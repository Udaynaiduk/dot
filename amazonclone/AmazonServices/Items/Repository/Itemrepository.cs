using Items.Entites;
using System.Security.Cryptography.X509Certificates;

namespace Items.Repository
{
    public class Itemrepository : IItemrepository
    {
        private readonly ItemsContext itemsContext;
        public Itemrepository(ItemsContext itemsContext)
        {
            this.itemsContext = itemsContext;
        }

        public bool Add(ItemDetails details)
        {
            try
            {
                itemsContext.Items.Add(details);
                itemsContext.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }


        }
        public IEnumerable<ItemDetails> GetItems()
        {
            return this.itemsContext.Items.ToList();
        }

    }
}
