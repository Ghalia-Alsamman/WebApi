using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ArtikelPrei
    {
        public int Id { get; set; }
        public int? ArtikelId { get; set; }
        public double? Preis { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public bool Aktiv { get; set; }

        public virtual Artikel Artikel { get; set; }
    }
}
