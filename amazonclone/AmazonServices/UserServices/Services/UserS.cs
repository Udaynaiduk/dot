using UserServices.Entites;
using UserServices.Repository;

namespace UserServices.Services
{
    public class UserS : IUserS
    {


        private readonly IUserrepository _repository;

        public UserS()//constructor
        {
        }

        public UserS(IUserrepository repo)
        {
            _repository = repo;
        }
        //create a Add function for User
      public  bool Add(User us)
        {
           return this._repository.Add(us);
        }
        //display method for User
        public List<User> GetAll()
        {
            return this._repository.GetAll();


        }
        //create Validate function for User
        public bool validate(User us)
        {
            return this._repository.Validate(us);
        }
    }
}
