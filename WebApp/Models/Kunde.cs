using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kunde
    {
        public Kunde()
        {
            AnsprechpartnerKundeKundeVaters = new HashSet<AnsprechpartnerKunde>();
            AnsprechpartnerKundeKundes = new HashSet<AnsprechpartnerKunde>();
            ArbeitskreiKundeArbeitskreisleiters = new HashSet<Arbeitskrei>();
            ArbeitskreiKundeBetreuers = new HashSet<Arbeitskrei>();
            Auftrags = new HashSet<Auftrag>();
            Belegs = new HashSet<Beleg>();
            InverseKundeVerband = new HashSet<Kunde>();
            Kontaktinformations = new HashSet<Kontaktinformation>();
            KundeArtikels = new HashSet<KundeArtikel>();
            KundeLoesungs = new HashSet<KundeLoesung>();
            KundeSegments = new HashSet<KundeSegment>();
            KundeVerleihartikels = new HashSet<KundeVerleihartikel>();
            Lieferants = new HashSet<Lieferant>();
            Mahnungs = new HashSet<Mahnung>();
            MailEmpfaengers = new HashSet<MailEmpfaenger>();
            MenueplanKundes = new HashSet<MenueplanKunde>();
            Mitgliedsbeitrags = new HashSet<Mitgliedsbeitrag>();
            Mitgliedschafts = new HashSet<Mitgliedschaft>();
            NewsletterKundes = new HashSet<NewsletterKunde>();
            VeranstaltungKundeHotels = new HashSet<Veranstaltung>();
            VeranstaltungKundeLeiters = new HashSet<Veranstaltung>();
            VeranstaltungKundeTagungsorts = new HashSet<Veranstaltung>();
            VeranstaltungKundes = new HashSet<VeranstaltungKunde>();
            VerteilerKundes = new HashSet<VerteilerKunde>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int BenutzerId { get; set; }
        public int? KundeVerbandId { get; set; }
        public int? KommentarId { get; set; }
        public int? LieferantId { get; set; }
        public int? KundenartId { get; set; }
        public int? KundenkategorieId { get; set; }
        public int? ZahlungsartId { get; set; }
        public string Debitorennummer { get; set; }
        public string NummerBeiKunde { get; set; }
        public string Titel { get; set; }
        public string Position { get; set; }
        public string Kuerzel { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string Bemerkung { get; set; }
        public bool VorblattFuerVerband { get; set; }
        public bool IstGesperrt { get; set; }
        public bool Aktiv { get; set; }
        public string Filialnummer { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Kommentar Kommentar { get; set; }
        public virtual Kunde KundeVerband { get; set; }
        public virtual Kundenart Kundenart { get; set; }
        public virtual Kundenkategorie Kundenkategorie { get; set; }
        public virtual Lieferant Lieferant { get; set; }
        public virtual Zahlungsart Zahlungsart { get; set; }
        public virtual ICollection<AnsprechpartnerKunde> AnsprechpartnerKundeKundeVaters { get; set; }
        public virtual ICollection<AnsprechpartnerKunde> AnsprechpartnerKundeKundes { get; set; }
        public virtual ICollection<Arbeitskrei> ArbeitskreiKundeArbeitskreisleiters { get; set; }
        public virtual ICollection<Arbeitskrei> ArbeitskreiKundeBetreuers { get; set; }
        public virtual ICollection<Auftrag> Auftrags { get; set; }
        public virtual ICollection<Beleg> Belegs { get; set; }
        public virtual ICollection<Kunde> InverseKundeVerband { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<KundeArtikel> KundeArtikels { get; set; }
        public virtual ICollection<KundeLoesung> KundeLoesungs { get; set; }
        public virtual ICollection<KundeSegment> KundeSegments { get; set; }
        public virtual ICollection<KundeVerleihartikel> KundeVerleihartikels { get; set; }
        public virtual ICollection<Lieferant> Lieferants { get; set; }
        public virtual ICollection<Mahnung> Mahnungs { get; set; }
        public virtual ICollection<MailEmpfaenger> MailEmpfaengers { get; set; }
        public virtual ICollection<MenueplanKunde> MenueplanKundes { get; set; }
        public virtual ICollection<Mitgliedsbeitrag> Mitgliedsbeitrags { get; set; }
        public virtual ICollection<Mitgliedschaft> Mitgliedschafts { get; set; }
        public virtual ICollection<NewsletterKunde> NewsletterKundes { get; set; }
        public virtual ICollection<Veranstaltung> VeranstaltungKundeHotels { get; set; }
        public virtual ICollection<Veranstaltung> VeranstaltungKundeLeiters { get; set; }
        public virtual ICollection<Veranstaltung> VeranstaltungKundeTagungsorts { get; set; }
        public virtual ICollection<VeranstaltungKunde> VeranstaltungKundes { get; set; }
        public virtual ICollection<VerteilerKunde> VerteilerKundes { get; set; }
    }
}
