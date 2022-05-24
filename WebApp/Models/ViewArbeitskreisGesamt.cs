using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArbeitskreisGesamt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AnzahlVeranstaltungen { get; set; }
        public int? AnzahlTeilnehmer { get; set; }
        public double? AuslastungVeranstaltungenDurchschnitt { get; set; }
        public string Leiter { get; set; }
        public string Betreuer { get; set; }
        public double Dauervorgabewert { get; set; }
        public int AnzahlTeilnehmerVorgabewert { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public string Benutzer { get; set; }
    }
}
