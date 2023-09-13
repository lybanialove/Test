namespace WebApplication1.Database.Entities
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Event>? events { get; set; }
    }
}
