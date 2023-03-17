using Rest_Api.Controllers.Entites;
using Rest_Api.Entites;

namespace Rest_Api.Controllers.GoldRepositroy
{
    public interface IGoldRepository
    {
        void Add(GoldOrnment go);
        List<GoldOrnment> display();
        bool update(int id, GoldOrnment go);
        bool delete(int id);
        GoldOrnment getbyid(int id);
    }
}