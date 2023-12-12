using System.ComponentModel.DataAnnotations;

namespace DbCwithLINKQ.Model
{
    public class Enrolled
    {
        [Key]
        public int Cid { get; set; }
        public int Sid { get; set; }
        public int Ci { get; set; }
        // Additional properties...

        // Navigation properties
        public Class Class { get; set; }
        public Student Student { get; set; }

    }
}
