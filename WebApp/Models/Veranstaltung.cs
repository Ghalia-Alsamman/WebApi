using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Veranstaltung
    {
        public Veranstaltung()
        {
            ChecklisteneintragVeranstaltungs = new HashSet<ChecklisteneintragVeranstaltung>();
            VeranstaltungKundes = new HashSet<VeranstaltungKunde>();
        }

        public int Id { get; set; }
        public int? ArbeitskreisId { get; set; }
        public int? KundeLeiterId { get; set; }
        public int? KundeHotelId { get; set; }
        public int? KundeTagungsortId { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public int AnzahlTeilnehmer { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime Enddatum { get; set; }
        public string Raumnummer { get; set; }
        public string RaumBeschreibung { get; set; }
        public string Beschreibung { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Arbeitskrei Arbeitskreis { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kunde KundeHotel { get; set; }
        public virtual Kunde KundeLeiter { get; set; }
        public virtual Kunde KundeTagungsort { get; set; }
        public virtual ICollection<ChecklisteneintragVeranstaltung> ChecklisteneintragVeranstaltungs { get; set; }
        public virtual ICollection<VeranstaltungKunde> VeranstaltungKundes { get; set; }
    }
}
