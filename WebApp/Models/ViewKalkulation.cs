using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKalkulation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BenutzerName { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public bool Deaktiviert { get; set; }
        public int KalkulationsartId { get; set; }
        public bool? IstKalkulationZurKonsolidierungFreigegeben { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? Kostenstellennummer { get; set; }
        public int? KostenstellenId { get; set; }
        public DateTime? PlanungVon { get; set; }
        public DateTime? PlanungBis { get; set; }
        public int? BenutzerGebietsleiterId { get; set; }
        public string BenutzerGebietsleiter { get; set; }
        public bool Aktiv { get; set; }
        public string RegionName { get; set; }
        public string BetriebsstaetteNameBkz { get; set; }
        public bool IstMfp { get; set; }
        public string Traeger { get; set; }
        public int Status { get; set; }
        public double BudgetHatFehler { get; set; }
    }
}
