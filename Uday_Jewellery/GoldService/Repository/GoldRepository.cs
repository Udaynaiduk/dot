using GoldService.Entites;

namespace GoldService.Repository
{
    public class GoldRepository : IGoldRepository
    {
        private readonly GoldContext data;
        public GoldRepository(GoldContext data)
        {
            this.data = data;
        }
        public bool Delete(int id)
        {
            GoldOrnment found = data.GoldOrnments.Find(id);
            if (found != null)
            {
                data.GoldOrnments.Remove(found);
                data.SaveChanges(true);
                return true;
            }
            return false;

        }

        public List<GoldOrnment> GetAll()
        {
            return data.GoldOrnments.ToList();
        }

        public void Insert(GoldOrnment go)
        {
            data.GoldOrnments.Add(go);
            data.SaveChanges();
        }

        public bool Update(int id, GoldOrnment go)
        {
            GoldOrnment found = data.GoldOrnments.Find(id);
            if (found != null)
            {
                found.Carat = go.Carat;
                found.Description = go.Description;
                data.SaveChanges(true);
                return true;
            }
            return false;
        }
         public GoldOrnment ById(int id)
        {
            return data.GoldOrnments.Find(id);
        }
    }
}
