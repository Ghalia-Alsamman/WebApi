using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeVeranstaltung
    {
        public int Id { get; set; }
        public int? KundeId { get; set; }
        public int? ArbeitskreisId { get; set; }
        public int? VeranstaltungId { get; set; }
        public int? KundeVaterId { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Teilnehmerart { get; set; }
        public string Veranstaltung { get; set; }
        public string Arbeitskreis { get; set; }
        public DateTime? Veranstaltungsdatum { get; set; }
        public string Tagungsort { get; set; }
    }
}
