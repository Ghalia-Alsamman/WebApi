using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewFinanzplanung
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? KalkulationId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public bool? FinanzplanungIstAbgeschlossen { get; set; }
        public string KalkulationsName { get; set; }
        public bool? BudgetIstGesperrt { get; set; }
        public string TraegerName { get; set; }
        public string BenutzerName { get; set; }
        public bool Aktiv { get; set; }
    }
}
