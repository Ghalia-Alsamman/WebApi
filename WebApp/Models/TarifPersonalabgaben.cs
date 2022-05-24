using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class TarifPersonalabgaben
    {
        public int Id { get; set; }
        public int TarifId { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double? Beihilfe { get; set; }
        public double? Fallpreisatz { get; set; }
        public double? SvGfb { get; set; }
        public double? SvSonstige { get; set; }
        public double? LohnsteigerungGfb { get; set; }
        public double? LohnsteigerungSonstige { get; set; }
        public double? Altersversorgung { get; set; }
        public double? WoechentlicheArbeitszeit { get; set; }
        public double? AnteilKv { get; set; }
        public double? AnteilAv { get; set; }
        public double? AnteilRv { get; set; }
        public double? AnteilPv { get; set; }
        public double? AnteilBg { get; set; }
        public double? AnteilHpv { get; set; }
        public double? AnteilSbp { get; set; }
        public double? AnteilFp { get; set; }
        public double? GfbUmlageAufwendungsAusglG { get; set; }
        public double? GfbKvpauschal { get; set; }
        public double? GfbRvpauschal { get; set; }
        public double? GfbLspauschal { get; set; }
        public bool Aktiv { get; set; }

        public virtual Tarif Tarif { get; set; }
    }
}
