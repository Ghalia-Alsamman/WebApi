using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKundeInMahnverfahren
    {
        public int Id { get; set; }
        public string Kunde { get; set; }
        public string Kundennummer { get; set; }
        public int? Mahnstufe { get; set; }
        public decimal? Mahnbetrag { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
    }
}
