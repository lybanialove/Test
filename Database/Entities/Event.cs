namespace WebApplication1.Database.Entities
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<DateTime> DateTimes { get; set; }
        public List<User>? user { get; set; }
        public Guid unique { get; set; }
    }
}
