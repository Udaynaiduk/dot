using Items.Entites;
using Items.Repository;

namespace Items.service
{
    public class Itemservice : IItemservice
    {
        private readonly IItemrepository itemrepository;

        public Itemservice(IItemrepository itemrepository)
        {
            this.itemrepository = itemrepository;
        }
        public bool Add(ItemDetails details)
        {
            return itemrepository.Add(details);
        }
        public List<ItemDetails> GetItems()
        {
            return itemrepository.GetItems();
        }
    }
}
