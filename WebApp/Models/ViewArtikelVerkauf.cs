using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelVerkauf
    {
        public int Id { get; set; }
        public string Artikelnummer { get; set; }
        public string Artikelname { get; set; }
        public string Artikelkategorie { get; set; }
    }
}
