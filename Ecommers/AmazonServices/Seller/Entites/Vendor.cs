using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seller.Entites
{
    public class Vendor
    {
        public string Name { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email{ get; set; }
        public string Password { get; set; }

    }
}
