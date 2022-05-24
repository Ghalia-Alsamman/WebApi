using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringArbeitsschritteMahlzeit
    {
        public CateringArbeitsschritteMahlzeit()
        {
            CateringProduktivzeitens = new HashSet<CateringProduktivzeiten>();
        }

        public int Id { get; set; }
        public int? CateringArbeitsschritteId { get; set; }
        public int? CateringMahlzeiteId { get; set; }
        public int? CateringEinheitenId { get; set; }
        public int? KalkulationId { get; set; }
        public bool? Standard { get; set; }
        public bool? Aktiv { get; set; }

        public virtual CateringArbeitsschritte CateringArbeitsschritte { get; set; }
        public virtual CateringEinheiten CateringEinheiten { get; set; }
        public virtual CateringMahlzeit CateringMahlzeite { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual ICollection<CateringProduktivzeiten> CateringProduktivzeitens { get; set; }
    }
}
