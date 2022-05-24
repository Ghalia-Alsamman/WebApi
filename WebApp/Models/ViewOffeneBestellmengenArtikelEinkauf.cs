using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewOffeneBestellmengenArtikelEinkauf
    {
        public int? Id { get; set; }
        public int? ArtikelId { get; set; }
        public string Name { get; set; }
        public string Nummer { get; set; }
        public double? Gebindegroesse { get; set; }
        public int? LieferantId { get; set; }
        public double? GebuchteMenge { get; set; }
        public double? BestellteMenge { get; set; }
        public string ExtMengeneinheitName { get; set; }
    }
}
