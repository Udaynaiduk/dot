using SliverService.Entites;

namespace SliverService.Service
{
    public interface ISliverService
    {
        void Add(SliverOrnment item);
        SliverOrnment ById(int id);
        List<SliverOrnment> GetAll();
        bool Modify(int id, SliverOrnment item);
        bool Remove(int id);
    }
}