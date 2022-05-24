using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BetriebsstaettedarlehenTilgungsplan
    {
        public int Id { get; set; }
        public DateTime Zahlungsdatum { get; set; }
        public decimal Startsaldo { get; set; }
        public decimal Annuitaet { get; set; }
        public decimal Tilgung { get; set; }
        public decimal Zinsen { get; set; }
        public bool IstSondertilgung { get; set; }
        public int? BetriebsstaettedarlehenId { get; set; }

        public virtual Betriebsstaettedarlehen Betriebsstaettedarlehen { get; set; }
    }
}
