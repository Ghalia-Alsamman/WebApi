using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArbeitskrei
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Leiter { get; set; }
        public string Betreuer { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public string BenutzerVorNachname { get; set; }
        public string Benutzervorname { get; set; }
        public string Benutzernachname { get; set; }
        public string Benutzername { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public int AnzahlTeilnehmer { get; set; }
        public double Dauer { get; set; }
        public string Beschreibung { get; set; }
    }
}
