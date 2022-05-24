using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BetriebsstaetteWareneinsatz
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int BenutzerId { get; set; }
        public double BudgetProBkt { get; set; }
        public double Fruehstueck { get; set; }
        public double Mittag { get; set; }
        public double Nachmittag { get; set; }
        public double Abend { get; set; }
        public double Sonstiges { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
    }
}
