using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuchungstagDefinition
    {
        public int Id { get; set; }
        public string NameBetriebsstaette { get; set; }
        public string NummerUndNameBetriebsstaette { get; set; }
        public string NameRegionaleZuordnung { get; set; }
        public string NameBenutzer { get; set; }
        public int? IdBuchungstagDefinition { get; set; }
        public int IstGlobal { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
    }
}
