using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Erloesplanungszeile
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int? SachkontoId { get; set; }
        public string Name { get; set; }
        public double Januar { get; set; }
        public double Februar { get; set; }
        public double Maerz { get; set; }
        public double April { get; set; }
        public double Mai { get; set; }
        public double Juni { get; set; }
        public double Juli { get; set; }
        public double August { get; set; }
        public double September { get; set; }
        public double Oktober { get; set; }
        public double November { get; set; }
        public double Dezember { get; set; }
        public string Identifizierungsschluessel { get; set; }
        public string Ursprungsklasse { get; set; }
        public int? KostenstelleId { get; set; }
        public int? KampagneId { get; set; }
        public string Bemerkung { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Kampagne Kampagne { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
