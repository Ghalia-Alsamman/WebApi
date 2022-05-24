using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBetriebstaetteFinanzplanung
    {
        public int Id { get; set; }
        public int? TraegerId { get; set; }
        public int? BundeslandId { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public int? TypId { get; set; }
        public string Name { get; set; }
        public string NummerUndName { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool Deaktiviert { get; set; }
        public bool Aktiv { get; set; }
    }
}
