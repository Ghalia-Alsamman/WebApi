using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BetriebsstaetteVerprobungsfaktor
    {
        public BetriebsstaetteVerprobungsfaktor()
        {
            KalkulationVerprobungs = new HashSet<KalkulationVerprobung>();
            KonsolidierungVerprobungs = new HashSet<KonsolidierungVerprobung>();
        }

        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? VerprobungsfaktorId { get; set; }
        public decimal Faktor { get; set; }
        public DateTime GueltigBis { get; set; }
        public bool? Aktiv { get; set; }
        public double? Bedarf { get; set; }
        public int? BerufsgruppeId { get; set; }
        public int? AuslastungsartId { get; set; }
        public double? Schluessel { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Verprobungsfaktor Verprobungsfaktor { get; set; }
        public virtual ICollection<KalkulationVerprobung> KalkulationVerprobungs { get; set; }
        public virtual ICollection<KonsolidierungVerprobung> KonsolidierungVerprobungs { get; set; }
    }
}
