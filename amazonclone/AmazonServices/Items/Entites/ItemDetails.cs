using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Items.Entites
{
    public class ItemDetails
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public int qty { get; set; }

        public string ImgUrl { get; set; }

    }
}
