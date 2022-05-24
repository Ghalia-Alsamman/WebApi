using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelname
    {
        public int Id { get; set; }
        public string Artikelname { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }
        public bool AfaListe { get; set; }
    }
}
