using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Auslastungszeile
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int Zeilennummer { get; set; }
        public int AuslastungsartId { get; set; }
        public double? Verteilung { get; set; }
        public double? Januar { get; set; }
        public double? Februar { get; set; }
        public double? Maerz { get; set; }
        public double? April { get; set; }
        public double? Mai { get; set; }
        public double? Juni { get; set; }
        public double? Juli { get; set; }
        public double? August { get; set; }
        public double? September { get; set; }
        public double? Oktober { get; set; }
        public double? November { get; set; }
        public double? Dezember { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
    }
}
