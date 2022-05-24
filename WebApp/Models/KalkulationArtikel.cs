using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationArtikel
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int ArtikelId { get; set; }
        public int? AufwandId { get; set; }
        public DateTime Kaufdatum { get; set; }
        public double Anzahl { get; set; }
        public double Preis { get; set; }
        public int AnzahlMonate { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Aufwand Aufwand { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
    }
}
