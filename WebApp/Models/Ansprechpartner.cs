using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Ansprechpartner
    {
        public Ansprechpartner()
        {
            AnsprechpartnerKundes = new HashSet<AnsprechpartnerKunde>();
            AnsprechpartnerLieferants = new HashSet<AnsprechpartnerLieferant>();
            Auftrags = new HashSet<Auftrag>();
            Kontaktinformations = new HashSet<Kontaktinformation>();
            Kostenstelles = new HashSet<Kostenstelle>();
        }

        public int Id { get; set; }
        public int? LieferantId { get; set; }
        public int? BetriebsstaettenId { get; set; }
        public int? TraegerId { get; set; }
        public int? StellenbeschreibungId { get; set; }
        public int? BundeslandId { get; set; }
        public int? AdresseId { get; set; }
        public int? BerufsgruppeId { get; set; }
        public string Anrede { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Mail { get; set; }
        public string Position { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Betriebsstaette Betriebsstaetten { get; set; }
        public virtual Bundesland Bundesland { get; set; }
        public virtual Lieferant Lieferant { get; set; }
        public virtual Stellenbeschreibung Stellenbeschreibung { get; set; }
        public virtual Traeger Traeger { get; set; }
        public virtual ICollection<AnsprechpartnerKunde> AnsprechpartnerKundes { get; set; }
        public virtual ICollection<AnsprechpartnerLieferant> AnsprechpartnerLieferants { get; set; }
        public virtual ICollection<Auftrag> Auftrags { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<Kostenstelle> Kostenstelles { get; set; }
    }
}
