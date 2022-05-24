using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelVerkaufGuenstigesterPrei
    {
        public int Id { get; set; }
        public double? Einkaufspreis { get; set; }
        public string Artikelkategorie { get; set; }
        public int ArtikelId { get; set; }
        public string VerkaufArtikelName { get; set; }
    }
}
