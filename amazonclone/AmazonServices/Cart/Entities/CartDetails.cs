namespace Cart.Entities
{
    public class CartDetails
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public int qty { get; set; }
        public double Price { get; set; }
        public double Value { get; set; }
        public DateTime DateAdded { get; set; }=DateTime.Now;
    }
}
