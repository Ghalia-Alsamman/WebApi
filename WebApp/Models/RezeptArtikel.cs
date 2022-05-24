using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class RezeptArtikel
    {
        public int Id { get; set; }
        public int RezeptId { get; set; }
        public int ArtikelId { get; set; }
        public double Menge { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Rezept Rezept { get; set; }
    }
}
