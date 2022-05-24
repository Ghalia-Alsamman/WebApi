using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Betriebsstaettedarlehen
    {
        public Betriebsstaettedarlehen()
        {
            BetriebsstaettedarlehenTilgungsplans = new HashSet<BetriebsstaettedarlehenTilgungsplan>();
        }

        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public string Bezeichnung { get; set; }
        public decimal Kreditbetrag { get; set; }
        public decimal Zinssatz { get; set; }
        public int Laufzeit { get; set; }
        public DateTime Startdatum { get; set; }
        public int Tilgungen { get; set; }
        public int? TypId { get; set; }
        public bool Aktiv { get; set; }
        public decimal Rate { get; set; }
        public bool IstRatendarlehen { get; set; }
        public int? SachkontoId { get; set; }
        public int? KostenstelleId { get; set; }
        public bool IstVergeben { get; set; }
        public bool IstTilgungsplanImportiert { get; set; }
        public bool AbgrenzungZinsen { get; set; }
        public bool AbgrenzungTilgung { get; set; }
        public int? SachkontoAbgrenzungZinsen { get; set; }
        public int? SachkontoAbgrenzungTilung { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual Sachkonto SachkontoAbgrenzungTilungNavigation { get; set; }
        public virtual Sachkonto SachkontoAbgrenzungZinsenNavigation { get; set; }
        public virtual DarlehenTypen Typ { get; set; }
        public virtual ICollection<BetriebsstaettedarlehenTilgungsplan> BetriebsstaettedarlehenTilgungsplans { get; set; }
    }
}
