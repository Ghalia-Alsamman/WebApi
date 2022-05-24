using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class WawistatistikZeile
    {
        public WawistatistikZeile()
        {
            WawistatistikSpaltes = new HashSet<WawistatistikSpalte>();
        }

        public int Id { get; set; }
        public int WawistatistikId { get; set; }
        public DateTime Datum { get; set; }
        public double? Spalte01 { get; set; }
        public double? Spalte02 { get; set; }
        public double? Spalte03 { get; set; }
        public double? Spalte04 { get; set; }
        public double? Spalte05 { get; set; }
        public double? Spalte06 { get; set; }
        public double? Spalte07 { get; set; }
        public double? Spalte08 { get; set; }
        public double? Spalte09 { get; set; }
        public double? Spalte10 { get; set; }
        public bool Aktiv { get; set; }

        public virtual Wawistatistik Wawistatistik { get; set; }
        public virtual ICollection<WawistatistikSpalte> WawistatistikSpaltes { get; set; }
    }
}
