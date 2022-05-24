using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLagerArtikelDurchschnittsprei
    {
        public int Id { get; set; }
        public int? ArtikelId { get; set; }
        public int? LagerId { get; set; }
        public double? Menge { get; set; }
        public double? Umsatz { get; set; }
        public double? Durchschnittspreis { get; set; }
    }
}
