using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Umlagekostenstelle
    {
        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public int? UKostenstelleId { get; set; }
        public double Prozent { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Kostenstelle UKostenstelle { get; set; }
    }
}
