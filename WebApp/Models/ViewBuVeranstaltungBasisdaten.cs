using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuVeranstaltungBasisdaten
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Leiter { get; set; }
        public string Hotel { get; set; }
        public string Tagungsort { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime Enddatum { get; set; }
        public int? Dauer { get; set; }
        public string Raumnr { get; set; }
        public string Raumbeschreibung { get; set; }
        public string Beschreibung { get; set; }
        public bool IstAufWebseiteVeröffentlicht { get; set; }
        public bool DarfAufWebseiteVeröffentlichtWerden { get; set; }
        public int MaxAnzTeilnehmer { get; set; }
        public string Arbeitskreis { get; set; }
        public string Benutzer { get; set; }
        public int? AnzTeilnehmerGesamt { get; set; }
        public double? Auslastung { get; set; }
        public double? AnteilChecklisteBearbeitet { get; set; }
        public int? AnzTeilnehmer { get; set; }
        public int? AnzReferenten { get; set; }
        public int? AnzSchnuppermitglieder { get; set; }
    }
}
