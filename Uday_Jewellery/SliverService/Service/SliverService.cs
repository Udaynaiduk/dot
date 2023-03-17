using SliverService.Entites;
using SliverService.Repository;

namespace SliverService.Service
{
    public class SliverService1 : ISliverService
    {
        private readonly ISliverRepository repository;
        public SliverService1(ISliverRepository repository)
        {
            this.repository = repository;
        }
        public void Add(SliverOrnment item)
        {
            this.repository.Insert(item);
        }

        public bool Modify(int id, SliverOrnment item)
        {
            return this.repository.Update(id, item);
        }

        public bool Remove(int id)
        {
            return this.repository.Delete(id);
        }


        public List<SliverOrnment> GetAll()
        {
            return this.repository.GetAll();
        }
        public SliverOrnment ById(int id)
        {
            return this.repository.ById(id);
        }

    }
}
