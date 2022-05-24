using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKalkulationKennzahlen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PlanungVon { get; set; }
        public DateTime? PlanungBis { get; set; }
        public bool IstFehlerfrei { get; set; }
        public bool? IstGesperrt { get; set; }
        public string Betriebsstaette { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public string RegionaleZuordnung { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public double? BKtsatz { get; set; }
        public double? MonatlichProduktivPlanstunden { get; set; }
        public double? Wareneinsatz { get; set; }
        public double? WareneinsatzProBkt { get; set; }
        public double? QMgesamt { get; set; }
        public double? PreisProQm { get; set; }
        public double? Standardleistungswert { get; set; }
        public double? Ergebnis { get; set; }
        public double? Umsatz { get; set; }
        public double? SollIstPlanstunden { get; set; }
        public double? Investitionssumme { get; set; }
    }
}
