using Microsoft.EntityFrameworkCore;
using UserServices.Entites;

namespace UserServices.Repository
{
    public class UserContext:DbContext

    {

       public UserContext()//constructor
        {

        }
        //parametrised constructor
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        //create table for User
        public virtual DbSet<User> Users { get; set; }
    }
}
