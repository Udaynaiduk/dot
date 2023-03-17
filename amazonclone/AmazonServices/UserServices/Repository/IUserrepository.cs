using UserServices.Entites;

namespace UserServices.Repository
{
    public interface IUserrepository
    {
        //declare the functions
        bool Add(User us);
        List<User> GetAll();
        bool Validate(User us);
    }
}