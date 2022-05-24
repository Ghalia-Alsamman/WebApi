using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLagerBestandHeute
    {
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public string Artikelname { get; set; }
        public string Artikelnummer { get; set; }
        public int LagerId { get; set; }
        public string Artikellistenname { get; set; }
        public string Lagername { get; set; }
        public double? Bestandsmenge { get; set; }
    }
}
