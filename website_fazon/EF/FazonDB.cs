using Microsoft.EntityFrameworkCore;
using website_fazon.Entities;

namespace website_fazon.EF
{
    public class FazonDB : DbContext
    {
        public FazonDB(DbContextOptions<FazonDB> opt)
            :base(opt)
        {}
        public DbSet<GrabEntity> Grabs { get; set; }
        public DbSet<RecyclingEntity> Recycls { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FazonDb;Integrated Security=True");
        }

    }
}
