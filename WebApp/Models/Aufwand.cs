using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Aufwand
    {
        public Aufwand()
        {
            KalkulationArtikels = new HashSet<KalkulationArtikel>();
        }

        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int SachkontoId { get; set; }
        public int KostenstelleId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Datum { get; set; }
        public double Einsatz { get; set; }
        public bool IstDaten { get; set; }
        public double IstWertVorjahr { get; set; }
        public double HochgerechneterWertLaufendesJahr { get; set; }
        public bool IstPersonal { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual ICollection<KalkulationArtikel> KalkulationArtikels { get; set; }
    }
}
