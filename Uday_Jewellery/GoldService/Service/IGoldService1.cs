using GoldService.Entites;

namespace GoldService.Service
{
    public interface IGoldService1
    {
        void Add(GoldOrnment item);
        List<GoldOrnment> GetAll();
        bool Modify(int id, GoldOrnment item);
        bool Remove(int id);
        GoldOrnment ById(int id);
    }
}