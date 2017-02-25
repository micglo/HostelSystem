using System.Data.Entity.ModelConfiguration;
using HostelSystem.Domain;

namespace HostelSystem.Dal.Config
{
    public class GoscCfg : EntityTypeConfiguration<Gosc>
    {
        public GoscCfg()
        {
            Property(g => g.Imie).IsRequired().HasMaxLength(100);
            Property(g => g.Nazwisko).IsRequired().HasMaxLength(100);
            Property(g => g.Email).IsRequired().HasMaxLength(30);
            HasKey(g => g.Id);
        }
    }
}