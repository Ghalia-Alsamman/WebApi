using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Abwesenheitsregel
    {
        public int Id { get; set; }
        public int? BundeslandId { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double? Prozentsatz { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Bundesland Bundesland { get; set; }
    }
}
