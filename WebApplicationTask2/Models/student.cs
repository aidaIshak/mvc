using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTask2.Models
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string imge { get; set; }
        [ForeignKey("department")]
        public int depid {  get; set; }
        public department department { get; set; }
    }
}
