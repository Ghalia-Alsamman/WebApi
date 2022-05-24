using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Wohnungsinformation
    {
        public int Id { get; set; }
        public int WohnungId { get; set; }
        public int? KostenstelleId { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double Groesse { get; set; }
        public double Kaltmiete { get; set; }
        public double Nebenkosten { get; set; }
        public double Pauschale1 { get; set; }
        public double Pauschale2 { get; set; }

        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Wohnung Wohnung { get; set; }
    }
}
