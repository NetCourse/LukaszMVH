using Microsoft.EntityFrameworkCore;
using VirtualHome.Models;

namespace VirtualHomeDAL
{
    class VirtualHomeDbContext : DbContext
    {
        public DbSet<Resident> Resident { get; set; }
        public DbSet<DoorLock> DoorLock { get; set; }
        public DbSet<TV> TV { get; set; }
        public DbSet<Light> Light { get; set; }
        public DbSet<Room> Room { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=XE2351861W1;Database=VirtualHomeDb;Integrated Security=SSPI");
        }
    }
}
