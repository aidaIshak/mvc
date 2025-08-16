namespace WebApplicationTask2.Models
{
    public class department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string img { get; set; }
        public List<student> students { get; set; }
    }
}
