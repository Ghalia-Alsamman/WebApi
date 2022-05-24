using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KostenstellePflegestufe
    {
        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public int? PflegestufeId { get; set; }
        public int? Auslastungsart { get; set; }

        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Pflegestufe Pflegestufe { get; set; }
    }
}
