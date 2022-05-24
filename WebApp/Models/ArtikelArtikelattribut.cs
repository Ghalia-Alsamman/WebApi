using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ArtikelArtikelattribut
    {
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public int ArtikelattributId { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Artikelattribut Artikelattribut { get; set; }
    }
}
