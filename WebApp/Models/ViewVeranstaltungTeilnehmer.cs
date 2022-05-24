using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewVeranstaltungTeilnehmer
    {
        public int? Id { get; set; }
        public string NameKomplett { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Teilnehmerart { get; set; }
        public string Veranstaltungsname { get; set; }
        public string Benutzer { get; set; }
        public string Arbeitskreis { get; set; }
        public int? VeranstaltungId { get; set; }
        public string MitgliedstatusBeiVeranstaltung { get; set; }
        public int? MitgliedstatusIdBeiVeranstaltung { get; set; }
    }
}
