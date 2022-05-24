using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAuftragsposition
    {
        public int Id { get; set; }
        public int ArtikelVerkaufId { get; set; }
        public double Anzahl { get; set; }
        public double Verkaufspreis { get; set; }
        public double Gesamtpreis { get; set; }
        public int KundeId { get; set; }
        public string Debitorenname { get; set; }
        public string Debitorennummer { get; set; }
        public string Artikelnummer { get; set; }
        public string Artikelname { get; set; }
        public int? MengeneinheitId { get; set; }
        public int? ArtikellisteId { get; set; }
        public string Artikelliste { get; set; }
        public string RezeptName { get; set; }
        public int? RezeptkategorieId { get; set; }
        public int? RezepteinheitId { get; set; }
        public DateTime Datum { get; set; }
    }
}
