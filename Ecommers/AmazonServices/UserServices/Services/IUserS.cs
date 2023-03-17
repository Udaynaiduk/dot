using UserServices.Entites;

namespace UserServices.Services
{
    public interface IUserS
    {
        bool Add(User us);
        List<User> GetAll();
        bool validate(User us);
    }
}