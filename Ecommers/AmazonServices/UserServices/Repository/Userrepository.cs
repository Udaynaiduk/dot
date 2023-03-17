using UserServices.Entites;
using UserServices.Services;

namespace UserServices.Repository
{
    public class Userrepository : IUserrepository
    {
        private readonly UserContext _userContext;
        public Userrepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public bool Add(User us)
        {
            try
            {
                _userContext.Add(us);
                _userContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public List<User> GetAll()
        {
           return  this._userContext.Users.ToList();
        }
      public   bool Validate(User us)
        {
            User found =_userContext.Users.Where(uu=>uu.Email== us.Email).FirstOrDefault();
            if(found!=null) {
            if(found.Password== us.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }

}
