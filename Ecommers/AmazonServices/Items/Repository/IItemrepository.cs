using Items.Entites;

namespace Items.Repository
{
    public interface IItemrepository
    {
        bool Add(ItemDetails details);
        List<ItemDetails> GetItems();
    }
}