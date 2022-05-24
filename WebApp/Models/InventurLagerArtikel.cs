using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class InventurLagerArtikel
    {
        public int Id { get; set; }
        public int LagerArtikelId { get; set; }
        public int InventurId { get; set; }
        public int? InventurLagerArtikelAbweichungsgrundId { get; set; }
        public double? Sollmenge { get; set; }
        public double? Istmenge { get; set; }
        public string ErklaerungAbweichungInventur { get; set; }
        public double? Durchschnittspreis { get; set; }

        public virtual Inventur Inventur { get; set; }
        public virtual InventurLagerArtikelAbweichungsgrund InventurLagerArtikelAbweichungsgrund { get; set; }
        public virtual LagerArtikel LagerArtikel { get; set; }
    }
}
