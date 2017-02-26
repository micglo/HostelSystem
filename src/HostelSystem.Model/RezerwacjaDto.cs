using System;
using System.Collections.Generic;

namespace HostelSystem.Model
{
    public class RezerwacjaDto : CommonDto
    {
        public string KodRezerwacji { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public decimal Cena { get; set; }
        public DateTime DataZameldowania { get; set; }
        public DateTime DataWymeldowania { get; set; }
        public decimal Prowizja { get; set; }

        public IEnumerable<GoscDto> Goscie { get; set; }
    }
}