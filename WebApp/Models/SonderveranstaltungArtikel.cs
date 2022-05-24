using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SonderveranstaltungArtikel
    {
        public int Id { get; set; }
        public int? SonderveranstaltungId { get; set; }
        public int? ArtikelId { get; set; }
        public double? Menge { get; set; }
        public double? Aufschlag { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Sonderveranstaltung Sonderveranstaltung { get; set; }
    }
}
