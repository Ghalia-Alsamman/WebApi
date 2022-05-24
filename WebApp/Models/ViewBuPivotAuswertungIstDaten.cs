using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuPivotAuswertungIstDaten
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
        public string Kostenstelle { get; set; }
        public string Kostenstellenbereich { get; set; }
        public DateTime? Datum { get; set; }
        public bool? IstLiquiditätswirksam { get; set; }
        public int EinsatzVorjahr { get; set; }
        public int EinsatzHochgerechnet { get; set; }
        public int PlanEinsatz { get; set; }
        public decimal? IstEinsatz { get; set; }
        public string Dienstart { get; set; }
        public int GehaltProMonat { get; set; }
        public int Personalfolgekosten { get; set; }
        public int Personalkosten { get; set; }
        public int Vkwert { get; set; }
        public int AnzahlBkt { get; set; }
        public int PreisProBkt { get; set; }
        public int ProduktivbedarfProMonat { get; set; }
        public int SummeQm { get; set; }
        public int ReinigendeFlaecheProWoche { get; set; }
        public int ReinigendeFlaecheProTag { get; set; }
        public int ReinigendeFlaecheProMonat { get; set; }
        public int ReinigendeFlaecheProBudget { get; set; }
        public int PersonalkostenProFlaeche { get; set; }
        public int SachkostenProFlaeche { get; set; }
        public int KostenProBett { get; set; }
        public int KostenProFlaeche { get; set; }
        public int ErloesProVollkraft { get; set; }
        public int DurchschnittlicherLeistungswert { get; set; }
        public int Stundenverrechnungssatz { get; set; }
        public int KostenProBettProTag { get; set; }
    }
}
