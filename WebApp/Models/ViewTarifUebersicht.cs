using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewTarifUebersicht
    {
        public int Id { get; set; }
        public string Nummer { get; set; }
        public string Name { get; set; }
        public double? Fallpreisatz { get; set; }
        public double? WoechentlicheArbeitszeit { get; set; }
        public double? AnteilAv { get; set; }
        public double? AnteilKv { get; set; }
        public double? AnteilRv { get; set; }
        public double? AnteilPv { get; set; }
        public double? AnteilBg { get; set; }
        public double? AnteilHpv { get; set; }
        public double? AnteilSbp { get; set; }
        public double? GfbUmlageAufwendungsAusglG { get; set; }
        public double? GfbKvpauschal { get; set; }
        public double? GfbRvpauschal { get; set; }
        public double? GfbLspauschal { get; set; }
        public double? LohnsteigerungGfb { get; set; }
        public double? LohnsteigerungSonstige { get; set; }
    }
}
