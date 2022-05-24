using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ArtikelVerkaufArtikelattribut
    {
        public int Id { get; set; }
        public int ArtikelVerkaufId { get; set; }
        public int ArtikelattributId { get; set; }

        public virtual ArtikelVerkauf ArtikelVerkauf { get; set; }
        public virtual Artikelattribut Artikelattribut { get; set; }
    }
}
