using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewArtikelVerkaufOffeneAuftragspositionen
    {
        public int Id { get; set; }
        public int? ArtikelId { get; set; }
        public double? BeauftragteMenge { get; set; }
        public double? GelieferteMenge { get; set; }
    }
}
