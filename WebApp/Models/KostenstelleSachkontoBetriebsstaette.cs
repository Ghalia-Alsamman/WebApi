using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KostenstelleSachkontoBetriebsstaette
    {
        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public int? SachkontoId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
