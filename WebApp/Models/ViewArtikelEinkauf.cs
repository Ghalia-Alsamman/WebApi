using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelEinkauf
    {
        public int Id { get; set; }
        public string Lieferantenname { get; set; }
        public string Artikelname { get; set; }
        public string Artikelnummer { get; set; }
        public string Artikelkategorie { get; set; }
        public bool Aktiv { get; set; }
        public bool Expr1 { get; set; }
        public bool Expr2 { get; set; }
    }
}
