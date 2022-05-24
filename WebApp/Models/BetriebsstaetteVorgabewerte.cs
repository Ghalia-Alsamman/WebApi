using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BetriebsstaetteVorgabewerte
    {
        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? KostenstelleId { get; set; }
        public string PropertyName { get; set; }
        public decimal? Neg1 { get; set; }
        public decimal? Pos1 { get; set; }
        public decimal? Neg2 { get; set; }
        public decimal? Pos2 { get; set; }
        public string PropertyTyp { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
    }
}
