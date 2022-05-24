using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewErteilteAuftraegeNochNichtVersandt
    {
        public int Id { get; set; }
        public int? ArtikelId { get; set; }
        public string Artikelname { get; set; }
        public double Sollmenge { get; set; }
        public double? LagerBestand { get; set; }
        public string Kundennummer { get; set; }
        public string Kundenname { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public double Auftragsvolumen { get; set; }
        public string Auftragstatus { get; set; }
        public string AuftragsnummerIntern { get; set; }
        public string AuftragsnummerExtern { get; set; }
    }
}
