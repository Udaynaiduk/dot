using UserServices.Entites;

namespace UserServices.Services
{
    public interface IUserS
    {
        //declare the functions
        bool Add(User us);
        List<User> GetAll();
        bool validate(User us);
    }
}