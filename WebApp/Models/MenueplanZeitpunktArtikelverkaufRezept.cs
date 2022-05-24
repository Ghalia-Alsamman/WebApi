using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenueplanZeitpunktArtikelverkaufRezept
    {
        public int Id { get; set; }
        public int? MenueplanZeitpunktId { get; set; }
        public int? ArtikelverkaufId { get; set; }
        public int? RezeptId { get; set; }
        public int Nummer { get; set; }

        public virtual ArtikelVerkauf Artikelverkauf { get; set; }
        public virtual MenueplanZeitpunkt MenueplanZeitpunkt { get; set; }
        public virtual Rezept Rezept { get; set; }
    }
}
