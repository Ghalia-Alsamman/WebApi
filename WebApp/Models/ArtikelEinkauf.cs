using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ArtikelEinkauf
    {
        public ArtikelEinkauf()
        {
            BestellObjektArtikels = new HashSet<BestellObjektArtikel>();
            Preis = new HashSet<Prei>();
        }

        public int Id { get; set; }
        public int LieferantId { get; set; }
        public int? ArtikelId { get; set; }
        public int? ArtikellisteId { get; set; }
        public int? SteuernId { get; set; }
        public int? MengeneinheitId { get; set; }
        public int? ArtikelattributId { get; set; }
        public string Artikelnummer { get; set; }
        public string Name { get; set; }
        public string EAn { get; set; }
        public string Beschreibung { get; set; }
        public string Kuerzel { get; set; }
        public bool? IstGebindeartikel { get; set; }
        public double? Gebindegroesse { get; set; }
        public double? Mindestbestellmenge { get; set; }
        public double? Umrechnungsfaktor { get; set; }
        public int? Prioritaet { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Artikelattribut Artikelattribut { get; set; }
        public virtual Artikelliste Artikelliste { get; set; }
        public virtual Lieferant Lieferant { get; set; }
        public virtual Mengeneinheit Mengeneinheit { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual ICollection<BestellObjektArtikel> BestellObjektArtikels { get; set; }
        public virtual ICollection<Prei> Preis { get; set; }
    }
}
