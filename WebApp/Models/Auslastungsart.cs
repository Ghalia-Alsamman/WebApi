using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Auslastungsart
    {
        public Auslastungsart()
        {
            Auslastungszeiles = new HashSet<Auslastungszeile>();
            BetriebsstaetteVerprobungsfaktors = new HashSet<BetriebsstaetteVerprobungsfaktor>();
            FaktorenPvsolls = new HashSet<FaktorenPvsoll>();
            KalkulationAuslastungsarts = new HashSet<KalkulationAuslastungsart>();
            KonsolidierungAuslastungsblocks = new HashSet<KonsolidierungAuslastungsblock>();
            Pflegesaetzes = new HashSet<Pflegesaetze>();
            SachkontoProzentBetriebsstaettes = new HashSet<SachkontoProzentBetriebsstaette>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public bool? InKalkulationAuslastungRelevant { get; set; }
        public string Kostenstellennummervon { get; set; }
        public string Kostenstellennummernbis { get; set; }

        public virtual ICollection<Auslastungszeile> Auslastungszeiles { get; set; }
        public virtual ICollection<BetriebsstaetteVerprobungsfaktor> BetriebsstaetteVerprobungsfaktors { get; set; }
        public virtual ICollection<FaktorenPvsoll> FaktorenPvsolls { get; set; }
        public virtual ICollection<KalkulationAuslastungsart> KalkulationAuslastungsarts { get; set; }
        public virtual ICollection<KonsolidierungAuslastungsblock> KonsolidierungAuslastungsblocks { get; set; }
        public virtual ICollection<Pflegesaetze> Pflegesaetzes { get; set; }
        public virtual ICollection<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
    }
}
