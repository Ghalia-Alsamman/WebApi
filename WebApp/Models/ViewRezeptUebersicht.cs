using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewRezeptUebersicht
    {
        public int Id { get; set; }
        public string RezeptName { get; set; }
        public string RezeptAnzeigename { get; set; }
        public double? Nettopreis { get; set; }
        public string RezeptkategorieName { get; set; }
        public int RezeptkategorieId { get; set; }
        public bool IstMenuebestandteil { get; set; }
        public int Ausgabemenge { get; set; }
        public string Ausgabemengeneinheit { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string BenutzerName { get; set; }
        public string Positionsgroesse { get; set; }
        public int? RezeptportionsgroesseId { get; set; }
        public double GrammProStueck { get; set; }
        public bool Aktiv { get; set; }
    }
}
