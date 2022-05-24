using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuArbeitskrei
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Arbeitskreisleiter { get; set; }
        public string Arbeitskreisbetreuer { get; set; }
        public double StandarddauerInTagen { get; set; }
        public int MaxAnzahlTeilnehmer { get; set; }
        public int? AnzVeranstaltungen { get; set; }
        public int? AnzTeilnehmer { get; set; }
        public double? DurchAuslastungVeranstaltung { get; set; }
        public bool AufWebseiteVeröffentlicht { get; set; }
        public bool DarfAufWebseiteVeröffentlichtWerden { get; set; }
        public string Benutzer { get; set; }
    }
}
