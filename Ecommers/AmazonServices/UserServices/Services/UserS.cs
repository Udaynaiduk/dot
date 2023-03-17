using UserServices.Entites;
using UserServices.Repository;

namespace UserServices.Services
{
    public class UserS : IUserS
    {


        private readonly IUserrepository _repository;
        public UserS(IUserrepository repo)
        {
            _repository = repo;
        }
      public  bool Add(User us)
        {
           return this._repository.Add(us);
        }
        public List<User> GetAll()
        {
            return this._repository.GetAll();


        }
        public bool validate(User us)
        {
            return this._repository.Validate(us);
        }
    }
}
