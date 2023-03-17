using SliverService.Entites;

namespace SliverService.Repository
{
    public interface ISliverRepository
    {
        SliverOrnment ById(int id);
        bool Delete(int id);
        List<SliverOrnment> GetAll();
        void Insert(SliverOrnment go);
        bool Update(int id, SliverOrnment go);
    }
}