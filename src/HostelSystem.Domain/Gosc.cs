using System;

namespace HostelSystem.Domain
{
    public class Gosc : CommonEntity
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public Guid? RezerwacjaId { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public Rezerwacja Rezerwacja { get; set; }
    }
}