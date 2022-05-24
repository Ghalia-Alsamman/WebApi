using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verwaltungsumlage
    {
        public int Id { get; set; }
        public int KalkulationBesitzerId { get; set; }
        public int KalkulationGehoertZuId { get; set; }
        public int BenutzerId { get; set; }
        public string BudgetName { get; set; }
        public double Verwaltungsumlage1 { get; set; }
        public double SummeGewStRelevant { get; set; }
        public double SummeKoeStRelevant { get; set; }
        public DateTime LetzteAktualisierung { get; set; }
        public double OperativesMgmtAufschlag { get; set; }
        public double SummeBg { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Kalkulation KalkulationBesitzer { get; set; }
        public virtual Kalkulation KalkulationGehoertZu { get; set; }
    }
}
