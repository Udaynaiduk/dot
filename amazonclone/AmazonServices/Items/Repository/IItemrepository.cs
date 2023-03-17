using Items.Entites;

namespace Items.Repository
{
    public interface IItemrepository
    {
        bool Add(ItemDetails details);
        IEnumerable<ItemDetails> GetItems();
    }
}