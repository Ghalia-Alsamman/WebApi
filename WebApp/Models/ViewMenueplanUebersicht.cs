using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewMenueplanUebersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MenueplanKategorieName { get; set; }
        public int? AnzahlMenue { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime GueltigBis { get; set; }
        public string BenutzerName { get; set; }
        public int? Status { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? LetzteVeroeffentlichung { get; set; }
    }
}
