using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserServices.Entites
{
    public class User
    {
        public string Name { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
