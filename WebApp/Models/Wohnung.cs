using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Wohnung
    {
        public Wohnung()
        {
            KalkulationWohnungs = new HashSet<KalkulationWohnung>();
            KonsolidierungWohnungs = new HashSet<KonsolidierungWohnung>();
            Wohnungsinformations = new HashSet<Wohnungsinformation>();
        }

        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? KostenstelleId { get; set; }
        public string Nr { get; set; }
        public double? Kaltmiete { get; set; }
        public double? Nebenkosten { get; set; }
        public double? Pauschale1 { get; set; }
        public double? Pauschale2 { get; set; }
        public double? Qm { get; set; }
        public bool Aktiv { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual ICollection<KalkulationWohnung> KalkulationWohnungs { get; set; }
        public virtual ICollection<KonsolidierungWohnung> KonsolidierungWohnungs { get; set; }
        public virtual ICollection<Wohnungsinformation> Wohnungsinformations { get; set; }
    }
}
