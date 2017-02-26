using System.Linq;
using HostelSystem.Domain;
using HostelSystem.Model;

namespace HostelSystem.Service.ModelFactory
{
    public class RezerwacjaFactory : IRezerwacjaFactory
    {
        public RezerwacjaDto CreateModel(Rezerwacja rezerwacja)
        {
            return new RezerwacjaDto
            {
                Id = rezerwacja.Id,
                KodRezerwacji = rezerwacja.KodRezerwacji,
                DataUtworzenia = rezerwacja.DataUtworzenia,
                Cena = rezerwacja.Cena,
                DataZameldowania = rezerwacja.DataZameldowania,
                DataWymeldowania = rezerwacja.DataWymeldowania,
                Prowizja = rezerwacja.Prowizja,
                Goscie = rezerwacja.Goscie.Select(CreateGoscDtoModel)
            };
        }

        private static GoscDto CreateGoscDtoModel(Gosc gosc)
        {
            return new GoscDto
            {
                Id = gosc.Id,
                Imie = gosc.Imie,
                Nazwisko = gosc.Nazwisko,
                Email = gosc.Email,
                Telefon = gosc.Telefon,
                Adres = gosc.Adres
            };
        }
    }
}