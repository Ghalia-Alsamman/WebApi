using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BestandLagerArtikel
    {
        public int Id { get; set; }
        public int BestandId { get; set; }
        public int LagerArtikelId { get; set; }
        public double? Sollmenge { get; set; }
        public double? Preis { get; set; }
        public double? Istmenge { get; set; }
        public string ErklaerungAbweichung { get; set; }

        public virtual Bestand Bestand { get; set; }
        public virtual LagerArtikel LagerArtikel { get; set; }
    }
}
