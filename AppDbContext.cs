using Microsoft.EntityFrameworkCore;

namespace DbCwithLINKQ.Model
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }

    }

    }


       
    
    
