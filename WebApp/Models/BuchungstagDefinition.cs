using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BuchungstagDefinition
    {
        public BuchungstagDefinition()
        {
            Buchungstags = new HashSet<Buchungstag>();
        }

        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? BenutzerId { get; set; }
        public bool IstGlobal { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual ICollection<Buchungstag> Buchungstags { get; set; }
    }
}
