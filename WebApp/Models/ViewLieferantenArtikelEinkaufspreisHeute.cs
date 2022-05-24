using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLieferantenArtikelEinkaufspreisHeute
    {
        public int Id { get; set; }
        public decimal? EinkaufspreisproIntEinheit { get; set; }
        public double EinkaufspreisproExtEinheit { get; set; }
        public int Lieferantid { get; set; }
        public string Name { get; set; }
        public string Artikelnummer { get; set; }
        public double? Mindestbestellmenge { get; set; }
        public bool? IstGebindeartikel { get; set; }
        public double? Gebindegroesse { get; set; }
        public int? Prioritaet { get; set; }
        public int? Artikelid { get; set; }
        public string Lieferantname { get; set; }
        public double? Umrechnungsfaktor { get; set; }
        public int? ArtikellisteId { get; set; }
        public int MengeneinheitId { get; set; }
        public string MengeneinheitName { get; set; }
    }
}
