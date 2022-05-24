using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class VerteilungBekoestigungstage
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public double Fruehstueck { get; set; }
        public double Mittagessen { get; set; }
        public double Nachmittagskaffee { get; set; }
        public double Abendessen { get; set; }
        public double Sonstiges { get; set; }
        public double Budget { get; set; }
        public double AnzahlBkt { get; set; }
        public bool Aktiv { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
    }
}
