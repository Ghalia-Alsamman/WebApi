using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewPreiseVerkaufsartikel
    {
        public int Id { get; set; }
        public string Artikelnummer { get; set; }
        public string Artikelname { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double? VonMenge { get; set; }
        public double? Nettopreis { get; set; }
        public string Artikelkategorie { get; set; }
        public int? ArtikelVerkaufId { get; set; }
        public int? AnzahlArtikelVerkauf { get; set; }
    }
}
