using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sonderposten
    {
        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public int? SachkontoId { get; set; }
        public int? SachkontoAufwZufuehrungId { get; set; }
        public int? SachkontoErtrFoerderungId { get; set; }
        public int? AfaZeileId { get; set; }
        public string Bezeichnung { get; set; }
        public string Zuschussgeber { get; set; }
        public double? Ursprungsbetrag { get; set; }
        public double? StandAnfangJahr { get; set; }
        public double? Zufuehrung { get; set; }
        public double? Aufloesung { get; set; }
        public DateTime? Datum { get; set; }

        public virtual AfAzeile AfaZeile { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual Sachkonto SachkontoAufwZufuehrung { get; set; }
        public virtual Sachkonto SachkontoErtrFoerderung { get; set; }
    }
}
