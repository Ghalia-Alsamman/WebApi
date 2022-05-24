using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BestellObjektArtikel
    {
        public int Id { get; set; }
        public int BestellObjektId { get; set; }
        public int ArtikelId { get; set; }
        public int? ArtikelEinkaufId { get; set; }
        public double BestellteMengeInterneMe { get; set; }
        public double? BestellteMenge { get; set; }
        public double? GelieferteMenge { get; set; }
        public double? GebuchteMenge { get; set; }
        public double? StckPreis { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual ArtikelEinkauf ArtikelEinkauf { get; set; }
        public virtual BestellObjekt BestellObjekt { get; set; }
    }
}
