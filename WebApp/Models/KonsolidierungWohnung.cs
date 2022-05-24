using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungWohnung
    {
        public int Id { get; set; }
        public int? WohnungId { get; set; }
        public int? KonsolidierungId { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double? Kaltmiete { get; set; }
        public double? Nebenkosten { get; set; }
        public double? Pauschale1 { get; set; }
        public double? Pauschale2 { get; set; }
        public double ErtragRenovierung { get; set; }
        public bool Aktiv { get; set; }

        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Wohnung Wohnung { get; set; }
    }
}
