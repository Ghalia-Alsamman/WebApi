using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SchwundLagerArtikel
    {
        public int Id { get; set; }
        public int? LagerArtikelId { get; set; }
        public double? Menge { get; set; }
        public int? SchwundId { get; set; }

        public virtual LagerArtikel LagerArtikel { get; set; }
        public virtual Schwund Schwund { get; set; }
    }
}
