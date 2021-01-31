using JLu.Models;
using Microsoft.EntityFrameworkCore;

namespace JLu.DAO
{
    public class PFContext : DbContext
    {
        public PFContext(DbContextOptions context) : base(context)
        {
        }

        public DbSet<Project> Blogs { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Study> Study { get; set; }
        public DbSet<ThatsMe> Me { get; set; }
    }
}