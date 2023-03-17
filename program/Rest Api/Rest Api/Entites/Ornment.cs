namespace Rest_Api.Controllers.Entites
{
    public abstract class Ornment
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
    }
}
