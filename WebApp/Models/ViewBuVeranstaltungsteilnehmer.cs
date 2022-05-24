using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuVeranstaltungsteilnehmer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Veranstaltung { get; set; }
        public string Arbeitskreis { get; set; }
        public string MitgliedstatusBeiVeranstaltung { get; set; }
    }
}
