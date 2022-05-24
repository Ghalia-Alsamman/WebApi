using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PlanbilanzPosition
    {
        public int Id { get; set; }
        public int? PlanbilanzId { get; set; }
        public int? PlanbilanzkontoId { get; set; }
        public int? PlanbilanzgegenkontoId { get; set; }
        public decimal Wert01 { get; set; }
        public decimal Wert02 { get; set; }
        public decimal Wert03 { get; set; }
        public decimal Wert04 { get; set; }
        public decimal Wert05 { get; set; }
        public decimal Wert06 { get; set; }
        public decimal Wert07 { get; set; }
        public decimal Wert08 { get; set; }
        public decimal Wert09 { get; set; }
        public decimal Wert10 { get; set; }
        public decimal Wert11 { get; set; }
        public decimal Wert12 { get; set; }
        public int Werttyp { get; set; }
        public bool Manuell { get; set; }
        public string Beschreibung { get; set; }
        public byte[] Nebenrechnung { get; set; }

        public virtual Planbilanz Planbilanz { get; set; }
        public virtual Planbilanzkonto Planbilanzgegenkonto { get; set; }
        public virtual Planbilanzkonto Planbilanzkonto { get; set; }
    }
}
