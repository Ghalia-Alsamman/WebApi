using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringProduktivzeiten
    {
        public int Id { get; set; }
        public int? CateringArbeitsschritteMahlzeitId { get; set; }
        public int? KalkulationId { get; set; }
        public int? CateringEinheitenId { get; set; }
        public double ZeitProStueck { get; set; }

        public virtual CateringArbeitsschritteMahlzeit CateringArbeitsschritteMahlzeit { get; set; }
        public virtual CateringEinheiten CateringEinheiten { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
    }
}
