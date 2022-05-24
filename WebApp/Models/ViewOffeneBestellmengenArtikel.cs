using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewOffeneBestellmengenArtikel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nummer { get; set; }
        public double? OffeneMenge { get; set; }
        public double? Mindestmenge { get; set; }
        public double? Lagerbestand { get; set; }
        public int? ArtikellisteId { get; set; }
        public string MengeneinheitName { get; set; }
        public int? MengeneinheitId { get; set; }
    }
}
