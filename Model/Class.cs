using System.ComponentModel.DataAnnotations;

namespace DbCwithLINKQ.Model
{
    public class Class
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public int Fid { get; set; }
        // Additional properties...

        // Navigation property
        public Faculty Faculty { get; set; }
        public List<Enrolled> Enrollments { get; set; }

    }
}
