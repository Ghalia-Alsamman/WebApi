using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Arbeitskrei
    {
        public Arbeitskrei()
        {
            Veranstaltungs = new HashSet<Veranstaltung>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int? KundeBetreuerId { get; set; }
        public int? KundeArbeitskreisleiterId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public double Dauer { get; set; }
        public int AnzahlTeilnehmer { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Kunde KundeArbeitskreisleiter { get; set; }
        public virtual Kunde KundeBetreuer { get; set; }
        public virtual ICollection<Veranstaltung> Veranstaltungs { get; set; }
    }
}
