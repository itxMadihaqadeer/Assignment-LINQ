using System.ComponentModel.DataAnnotations;

namespace DbCwithLINKQ.Model
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public int Standing { get; set; }
        // Additional properties...

        // Navigation property
        public List<Enrolled> Enrollments { get; set; }

    }
}
