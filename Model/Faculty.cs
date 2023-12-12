using System.ComponentModel.DataAnnotations;

namespace DbCwithLINKQ.Model
{
    public class Faculty
    {
        [Key]
        public int Fid { get; set; }
        public string Fname { get; set; }
        public int Deptid { get; set; }
        public string Standing { get; set; }
        // Additional properties...

        // Navigation property
        public List<Class> Classes { get; set; }

    }
}
