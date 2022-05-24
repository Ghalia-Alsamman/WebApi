using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Artikelattribut
    {
        public Artikelattribut()
        {
            ArtikelArtikelattributs = new HashSet<ArtikelArtikelattribut>();
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            ArtikelVerkaufArtikelattributs = new HashSet<ArtikelVerkaufArtikelattribut>();
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
        }

        public int Id { get; set; }
        public string Kennziffer { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<ArtikelArtikelattribut> ArtikelArtikelattributs { get; set; }
        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<ArtikelVerkaufArtikelattribut> ArtikelVerkaufArtikelattributs { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
    }
}
