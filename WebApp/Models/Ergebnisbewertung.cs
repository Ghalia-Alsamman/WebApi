using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Ergebnisbewertung
    {
        public int Id { get; set; }
        public int KennzahlId { get; set; }
        public double? WertVon { get; set; }
        public double? WertBis { get; set; }
        public int? EnumKennzahlFarbe { get; set; }
        public bool Aktiv { get; set; }

        public virtual Kennzahl Kennzahl { get; set; }
    }
}
