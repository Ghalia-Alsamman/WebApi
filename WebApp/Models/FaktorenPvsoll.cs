using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class FaktorenPvsoll
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? AuslastungsartId { get; set; }
        public double? Pflegestufe0 { get; set; }
        public double? Pflegestufe1 { get; set; }
        public double? Pflegestufe2 { get; set; }
        public double? Pflegestufe3 { get; set; }
        public double? Pflegestufe3p { get; set; }
        public double Nachtwachepauschal { get; set; }
        public double Nachtwacheverprobung { get; set; }
        public DateTime GueltigBis { get; set; }
        public bool Aktiv { get; set; }
        public double Psg2Zuschlag { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
    }
}
