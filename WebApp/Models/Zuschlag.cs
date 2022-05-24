using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Zuschlag
    {
        public Zuschlag()
        {
            AuftragZuschlags = new HashSet<AuftragZuschlag>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int? SteuernId { get; set; }
        public double Betrag { get; set; }
        public string Name { get; set; }
        public string Nummer { get; set; }
        public string Bemerkung { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool Relativ { get; set; }
        public bool StandardaufschlagFuerAuftrag { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual ICollection<AuftragZuschlag> AuftragZuschlags { get; set; }
    }
}
