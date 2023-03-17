using Items.Entites;

namespace Items.service
{
    public interface IItemservice
    {
        bool Add(ItemDetails details);
        IEnumerable<ItemDetails> GetItems();
    }
}