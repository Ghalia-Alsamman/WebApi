using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewVerlieheneArtikel
    {
        public int? Id { get; set; }
        public int KundeId { get; set; }
        public int VerleihartikelId { get; set; }
        public double? Menge { get; set; }
        public string KundeName { get; set; }
    }
}
