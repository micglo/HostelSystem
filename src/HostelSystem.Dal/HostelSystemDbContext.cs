using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HostelSystem.Dal.Config;
using HostelSystem.Domain;

namespace HostelSystem.Dal
{
    public class HostelSystemDbContext : DbContext
    {
        public HostelSystemDbContext()
            : base("name=DbConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Rezerwacja> Rezerwacja { get; set; }
        public DbSet<Gosc> Gosc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RezerwacjaCfg());
            modelBuilder.Configurations.Add(new GoscCfg());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}