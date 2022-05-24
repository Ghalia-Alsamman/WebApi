using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuPivotAuswertungStandard
    {
        public int? Id { get; set; }
        public string Gesellschaft { get; set; }
        public string Bundesland { get; set; }
        public string Träger { get; set; }
        public string Objektnummer { get; set; }
        public string Debitor { get; set; }
        public string Gebietsleiter { get; set; }
        public string Budgetname { get; set; }
        public int? Planungsjahr { get; set; }
        public string Sachkonto { get; set; }
        public string Sachkontengruppe { get; set; }
        public int? Kostenstelle { get; set; }
        public string Kostenstellenbereich { get; set; }
        public DateTime? Datum { get; set; }
        public int? IstLiquiditätswirksam { get; set; }
        public double EinsatzVorjahr { get; set; }
        public double EinsatzHochgerechnet { get; set; }
        public double PlanEinsatz { get; set; }
        public int IstEinsatz { get; set; }
        public string Dienstart { get; set; }
        public double GehaltProMonat { get; set; }
        public double Personalfolgekosten { get; set; }
        public double Personalkosten { get; set; }
        public double Vkwert { get; set; }
        public double AnzahlBkt { get; set; }
        public double? PreisProBkt { get; set; }
        public double? ProduktivbedarfProMonat { get; set; }
        public double? SummeQm { get; set; }
        public double? ReinigendeFlaecheProWoche { get; set; }
        public double? ReinigendeFlaecheProTag { get; set; }
        public double? ReinigendeFlaecheProMonat { get; set; }
        public double? ReinigendeFlaecheProBudget { get; set; }
        public double? PersonalkostenProFlaeche { get; set; }
        public double? SachkostenProFlaeche { get; set; }
        public double? KostenProBett { get; set; }
        public double? KostenProFlaeche { get; set; }
        public double? ErloesProVollkraft { get; set; }
        public double? DurchschnittlicherLeistungswert { get; set; }
        public double? Stundenverrechnungssatz { get; set; }
        public double? KostenProBettProTag { get; set; }
    }
}
