using Microsoft.EntityFrameworkCore;

namespace EfBug.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
        {
        }

        public DbSet<BaseEntity> Bases { get; set; }

        public DbSet<ChildEntityOne> Ones { get; set; }

        public DbSet<ChildEntityTwo> Twos { get; set; }

        public DbSet<ChildEntityThree> Threes { get; set; }

        public DbSet<OtherEntity> Others { get; set; }
    }
}