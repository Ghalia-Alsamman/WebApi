using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelnameArtikelnummer
    {
        public int Id { get; set; }
        public string Artikelname { get; set; }
        public string Artikelnummer { get; set; }
        public int ArtikellisteId { get; set; }
        public string ArtikellisteName { get; set; }
    }
}
