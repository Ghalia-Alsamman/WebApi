using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class VorgabewerteKennzahlenabweichung
    {
        public int Id { get; set; }
        public string Kennzahl { get; set; }
        public int? KostenstelleId { get; set; }
        public double? AbweichungOben1 { get; set; }
        public double? AbweichungOben2 { get; set; }
        public double? AbweichungUnten1 { get; set; }
        public double? AbweichungUnten2 { get; set; }
        public string AbweichungOben1Farbe { get; set; }
        public string AbweichungOben2Farbe { get; set; }
        public string AbweichungUnten1Farbe { get; set; }
        public string AbweichungUnten2Farbe { get; set; }

        public virtual Kostenstelle Kostenstelle { get; set; }
    }
}
