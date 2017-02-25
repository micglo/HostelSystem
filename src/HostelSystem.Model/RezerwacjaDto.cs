using System.Collections.Generic;

namespace HostelSystem.Model
{
    public class RezerwacjaDto : CommonDto
    {
        public string KodRezerwacji { get; set; }
        public string DataUtworzenia { get; set; }
        public decimal Cena { get; set; }
        public string DataZameldowania { get; set; }
        public string DataWymeldowania { get; set; }
        public decimal Prowizja { get; set; }

        public IEnumerable<GoscDto> Goscie { get; set; }
    }
}