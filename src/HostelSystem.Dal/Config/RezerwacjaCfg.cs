using System.Data.Entity.ModelConfiguration;
using HostelSystem.Domain;

namespace HostelSystem.Dal.Config
{
    public class RezerwacjaCfg : EntityTypeConfiguration<Rezerwacja>
    {
        public RezerwacjaCfg()
        {
            Property(r => r.KodRezerwacji).IsRequired().HasMaxLength(10);
            Property(r => r.DataUtworzenia).IsRequired();
            Property(r => r.Cena).IsRequired();
            Property(r => r.DataZameldowania).IsOptional();
            Property(r => r.DataWymeldowania).IsOptional();
            Property(r => r.Prowizja).IsOptional();
            HasKey(r => r.Id);
            HasMany(r => r.Goscie).WithOptional(g => g.Rezerwacja);
        }
    }
}