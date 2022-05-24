using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewVeranstaltung
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnzahlTeilnehmerMax { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime Enddatum { get; set; }
        public string Raumnummer { get; set; }
        public string RaumBeschreibung { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string Arbeitskreis { get; set; }
        public string BenutzerGesamtname { get; set; }
        public string BenutzerName { get; set; }
        public string BenutzerVorname { get; set; }
        public string Username { get; set; }
        public string LeiterName { get; set; }
        public string LeiterVorname { get; set; }
        public string HotelName { get; set; }
        public string TagungsortName { get; set; }
        public int? AnzahlTeilnehmer { get; set; }
        public double? AuslastungVeranstaltung { get; set; }
        public int? Dauer { get; set; }
        public int? ArbeitskreisId { get; set; }
    }
}
