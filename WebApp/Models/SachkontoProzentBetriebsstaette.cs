using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontoProzentBetriebsstaette
    {
        public int Id { get; set; }
        public int? SachkontoId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? AuslastungsartId { get; set; }
        public int? PflegestufeId { get; set; }
        public int? KostenstelleId { get; set; }
        public double? Prozentsatz { get; set; }
        public DateTime? GueltigBis { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Pflegestufe Pflegestufe { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
