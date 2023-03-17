using GoldService.Entites;
using GoldService.Repository;

namespace GoldService.Service
{
    public class GoldServices : IGoldService1
    {
        private readonly IGoldRepository repository;
        public GoldServices(IGoldRepository repository)
        {
            this.repository = repository;
        }
        public void Add(GoldOrnment item)
        {
            this.repository.Insert(item);
        }

        public bool Modify(int id, GoldOrnment item)
        {
            return this.repository.Update(id,item);
        }

        public bool Remove(int id)
        {
            return this.repository.Delete(id);
        }


        public List<GoldOrnment> GetAll()
        {
            return this.repository.GetAll();
        }
       public GoldOrnment ById(int id)
        {
            return this.repository.ById(id);
        }


    }
}
