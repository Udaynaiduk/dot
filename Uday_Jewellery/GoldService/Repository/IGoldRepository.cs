using GoldService.Entites;

namespace GoldService.Repository
{
    public interface IGoldRepository
    {
        bool Delete(int id);
        
        List<GoldOrnment> GetAll();
        void Insert(GoldOrnment go);
       
        bool Update(int id, GoldOrnment go);
        GoldOrnment ById(int id);


    }
}