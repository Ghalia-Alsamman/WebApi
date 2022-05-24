using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Artikel
    {
        public Artikel()
        {
            ArtikelArtikelattributs = new HashSet<ArtikelArtikelattribut>();
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            ArtikelPreis = new HashSet<ArtikelPrei>();
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
            ArtikelmerklisteEintrags = new HashSet<ArtikelmerklisteEintrag>();
            BestellObjektArtikels = new HashSet<BestellObjektArtikel>();
            KalkulationArtikels = new HashSet<KalkulationArtikel>();
            KundeArtikels = new HashSet<KundeArtikel>();
            LagerArtikels = new HashSet<LagerArtikel>();
            RezeptArtikels = new HashSet<RezeptArtikel>();
            SonderveranstaltungArtikels = new HashSet<SonderveranstaltungArtikel>();
        }

        public int Id { get; set; }
        public int? ArtikellisteId { get; set; }
        public int? LieferantId { get; set; }
        public int? MengeneinheitId { get; set; }
        public string Zusatzname { get; set; }
        public string Artikelname { get; set; }
        public string Beschreibung { get; set; }
        public string Kuerzel { get; set; }
        public double? Preis { get; set; }
        public int? AnzahlAbschreibungsmonate { get; set; }
        public int? SteuernId { get; set; }
        public string Artikelnummer { get; set; }
        public double? Gebindegroesse { get; set; }
        public double? Mindestmenge { get; set; }
        public double? Meldemenge { get; set; }
        public bool? Standardartikel { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Artikelliste Artikelliste { get; set; }
        public virtual Lieferant Lieferant { get; set; }
        public virtual Mengeneinheit Mengeneinheit { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual ICollection<ArtikelArtikelattribut> ArtikelArtikelattributs { get; set; }
        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<ArtikelPrei> ArtikelPreis { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual ICollection<ArtikelmerklisteEintrag> ArtikelmerklisteEintrags { get; set; }
        public virtual ICollection<BestellObjektArtikel> BestellObjektArtikels { get; set; }
        public virtual ICollection<KalkulationArtikel> KalkulationArtikels { get; set; }
        public virtual ICollection<KundeArtikel> KundeArtikels { get; set; }
        public virtual ICollection<LagerArtikel> LagerArtikels { get; set; }
        public virtual ICollection<RezeptArtikel> RezeptArtikels { get; set; }
        public virtual ICollection<SonderveranstaltungArtikel> SonderveranstaltungArtikels { get; set; }
    }
}
