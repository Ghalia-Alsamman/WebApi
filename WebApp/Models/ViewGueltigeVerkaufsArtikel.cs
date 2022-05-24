using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewGueltigeVerkaufsArtikel
    {
        public int Id { get; set; }
        public string Artikelnummer { get; set; }
        public string Name { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
