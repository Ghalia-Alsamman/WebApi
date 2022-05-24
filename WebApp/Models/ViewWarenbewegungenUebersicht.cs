using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewWarenbewegungenUebersicht
    {
        public int Id { get; set; }
        public int LagerId { get; set; }
        public string Artikelnummer { get; set; }
        public string Artikelname { get; set; }
        public double Menge { get; set; }
        public string Mengeneinheitname { get; set; }
        public double StckPreis { get; set; }
        public string Ersteller { get; set; }
        public DateTime Aenderungsdatum { get; set; }
    }
}
