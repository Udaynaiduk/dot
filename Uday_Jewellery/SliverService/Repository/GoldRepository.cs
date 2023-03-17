using SliverService.Entites;

namespace SliverService.Repository
{
    public class SliverRepository : ISliverRepository
    {
        private readonly SliverContext data;
        public SliverRepository(SliverContext data)
        {
            this.data = data;
        }
        public bool Delete(int id)
        {
            SliverOrnment found = data.SliverOrnments.Find(id);
            if (found != null)
            {
                data.SliverOrnments.Remove(found);
                data.SaveChanges(true);
                return true;
            }
            return false;

        }

        public List<SliverOrnment> GetAll()
        {
            return data.SliverOrnments.ToList();
        }

        public void Insert(SliverOrnment go)
        {
            data.SliverOrnments.Add(go);
            data.SaveChanges();
        }

        public bool Update(int id, SliverOrnment go)
        {
            SliverOrnment found = data.SliverOrnments.Find(id);
            if (found != null)
            {
                found.Purity = go.Purity;
                found.Description = go.Description;
                data.SaveChanges(true);
                return true;
            }
            return false;
        }
        public SliverOrnment ById(int id)
        {
            return data.SliverOrnments.Find(id);
        }
    }
}
