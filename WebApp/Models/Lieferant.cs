using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Lieferant
    {
        public Lieferant()
        {
            AnsprechpartnerLieferants = new HashSet<AnsprechpartnerLieferant>();
            Ansprechpartners = new HashSet<Ansprechpartner>();
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            Artikels = new HashSet<Artikel>();
            InverseLieferantVerband = new HashSet<Lieferant>();
            Kontaktinformations = new HashSet<Kontaktinformation>();
            Kundes = new HashSet<Kunde>();
            LieferantMailZugangsdatens = new HashSet<LieferantMailZugangsdaten>();
            RechnungseingangslisteSachkontos = new HashSet<RechnungseingangslisteSachkonto>();
        }

        public int Id { get; set; }
        public int? LieferantVerbandId { get; set; }
        public int? KundeId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? KommentarId { get; set; }
        public int? AdresseId { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public string Kreditorennummer { get; set; }
        public string NummerBeiLieferant { get; set; }
        public string Kuerzel { get; set; }
        public string Iln { get; set; }
        public bool? IstZentralerLieferant { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kommentar Kommentar { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Lieferant LieferantVerband { get; set; }
        public virtual ICollection<AnsprechpartnerLieferant> AnsprechpartnerLieferants { get; set; }
        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<Artikel> Artikels { get; set; }
        public virtual ICollection<Lieferant> InverseLieferantVerband { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<Kunde> Kundes { get; set; }
        public virtual ICollection<LieferantMailZugangsdaten> LieferantMailZugangsdatens { get; set; }
        public virtual ICollection<RechnungseingangslisteSachkonto> RechnungseingangslisteSachkontos { get; set; }
    }
}
