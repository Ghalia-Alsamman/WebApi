using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kontaktinformation
    {
        public Kontaktinformation()
        {
            Adresses = new HashSet<Adresse>();
            Kontoinformations = new HashSet<Kontoinformation>();
            Lieferdatens = new HashSet<Lieferdaten>();
            Mailadresses = new HashSet<Mailadresse>();
            Rabattinformationens = new HashSet<Rabattinformationen>();
            Telefonnummers = new HashSet<Telefonnummer>();
            Urls = new HashSet<Url>();
        }

        public int Id { get; set; }
        public int? AnredeId { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public int? BenutzerId { get; set; }
        public int? KundeId { get; set; }
        public int? LieferantId { get; set; }
        public int? MitartbeiterId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? StandardkommunikationskanalId { get; set; }
        public bool? WieVerband { get; set; }
        public string Anredetext { get; set; }

        public virtual Anrede Anrede { get; set; }
        public virtual Ansprechpartner Ansprechpartner { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Lieferant Lieferant { get; set; }
        public virtual Mitarbeiter Mitartbeiter { get; set; }
        public virtual Standardkommunikationskanal Standardkommunikationskanal { get; set; }
        public virtual ICollection<Adresse> Adresses { get; set; }
        public virtual ICollection<Kontoinformation> Kontoinformations { get; set; }
        public virtual ICollection<Lieferdaten> Lieferdatens { get; set; }
        public virtual ICollection<Mailadresse> Mailadresses { get; set; }
        public virtual ICollection<Rabattinformationen> Rabattinformationens { get; set; }
        public virtual ICollection<Telefonnummer> Telefonnummers { get; set; }
        public virtual ICollection<Url> Urls { get; set; }
    }
}
