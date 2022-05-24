using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewVeranstaltungBasisdaten
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Leiter { get; set; }
        public string Hotel { get; set; }
        public string Tagungsort { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime Enddatum { get; set; }
        public int? Dauer { get; set; }
        public string Raumnummer { get; set; }
        public string RaumBeschreibung { get; set; }
        public string Beschreibung { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public int AnzahlTeilnehmerVorgabewert { get; set; }
        public string Arbeitskreis { get; set; }
        public string Benutzer { get; set; }
        public int? AnzahlTeilnehmerGesamt { get; set; }
        public double? AuslastungVeranstaltung { get; set; }
        public double? ProzentsatzChecklisteBearbeitet { get; set; }
        public int? AnzahlTeilnehmer { get; set; }
        public int? AnzahlReferenten { get; set; }
        public int? AnzahlSchnuppermitglieder { get; set; }
    }
}
