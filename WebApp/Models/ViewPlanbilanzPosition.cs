using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewPlanbilanzPosition
    {
        public long? Id { get; set; }
        public int PlanbilanzPositionId { get; set; }
        public int? PlanbilanzId { get; set; }
        public int? PlanbilanzkontoId { get; set; }
        public int? ParentId { get; set; }
        public decimal? Wert { get; set; }
        public decimal? Vorjahreswert { get; set; }
        public bool? Manuell { get; set; }
        public byte[] Nebenrechnung { get; set; }
    }
}
