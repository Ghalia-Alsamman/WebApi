using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PlanbilanzMittelfristplanung
    {
        public PlanbilanzMittelfristplanung()
        {
            PlanbilanzMittelfristplanungPositions = new HashSet<PlanbilanzMittelfristplanungPosition>();
        }

        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public string Bezeichnung { get; set; }
        public int BenutzerId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual ICollection<PlanbilanzMittelfristplanungPosition> PlanbilanzMittelfristplanungPositions { get; set; }
    }
}
