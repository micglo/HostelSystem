using System;
using System.Collections.Generic;

namespace HostelSystem.Domain
{
    public class Rezerwacja : CommonEntity
    {
        public string KodRezerwacji { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public decimal Cena { get; set; }
        public DateTime DataZameldowania { get; set; }
        public DateTime DataWymeldowania { get; set; }
        public decimal Prowizja { get; set; }

        public ICollection<Gosc> Goscie { get; set; }
    }
}