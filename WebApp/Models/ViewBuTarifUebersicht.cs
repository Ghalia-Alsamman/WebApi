using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuTarifUebersicht
    {
        public int Id { get; set; }
        public string Tarifname { get; set; }
        public string Tarifnummer { get; set; }
        public double? Fallpreissatz { get; set; }
        public double? WöchentlicheArbeitszeit { get; set; }
        public double? Krankenversicherung { get; set; }
        public double? Arbeitslosenversicherung { get; set; }
        public double? Rentenversicherung { get; set; }
        public double? Pflegeversicherung { get; set; }
        public double? Berufsgenossenschaft { get; set; }
        public double? Haftpflichtversicherung { get; set; }
        public double? Schwerbehindertenpauschale { get; set; }
        public double? UmlageNachDemAufwendungsausgleichsgesetz { get; set; }
        public double? KrankenversicherungGfB { get; set; }
        public double? RentenversicherungGfB { get; set; }
        public double? LohnsteuerGfB { get; set; }
        public double? LohnsteigerungGfb { get; set; }
        public double? LohnsteigerungSonstige { get; set; }
    }
}
