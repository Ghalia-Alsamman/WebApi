using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ZiviTarif
    {
        public int Id { get; set; }
        public double? Sold1 { get; set; }
        public double? Sold2 { get; set; }
        public double? Sold3 { get; set; }
        public double? VerpflegungFruehstueck { get; set; }
        public double? VerpflegungMittagessen { get; set; }
        public double? VerpflegungAbendessen { get; set; }
        public double? Arbeitskleidung { get; set; }
        public double? Reinigung { get; set; }
        public double? FahrtkostenProKilometer { get; set; }
        public double? FahrtkostenHoechstbetrag { get; set; }
        public double? EntlassungsGeld { get; set; }
        public double? WeihnachtsGeld { get; set; }
        public double? Pauschalerstattung { get; set; }
        public double? Erstattungentlassungsgeld { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public bool Aktiv { get; set; }
    }
}
