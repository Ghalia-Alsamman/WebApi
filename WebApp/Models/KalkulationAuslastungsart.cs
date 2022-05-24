using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationAuslastungsart
    {
        public KalkulationAuslastungsart()
        {
            AuslastungMonats = new HashSet<AuslastungMonat>();
        }

        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int AuslastungsartId { get; set; }
        public int BenutzerId { get; set; }
        public double? AnwesenheitPst0Prozent { get; set; }
        public double? AnwesenheitPst1Prozent { get; set; }
        public double? AnwesenheitPst2Prozent { get; set; }
        public double? AnwesenheitPst3Prozent { get; set; }
        public double? AnwesenheitPst3plusProzent { get; set; }
        public double? AbwesenheitPst0Prozent { get; set; }
        public double? AbwesenheitPst1Prozent { get; set; }
        public double? AbwesenheitPst2Prozent { get; set; }
        public double? AbwesenheitPst3Prozent { get; set; }
        public double? AbwesenheitPst3plusProzent { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public int? PflegesatzId { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Pflegesaetze Pflegesatz { get; set; }
        public virtual ICollection<AuslastungMonat> AuslastungMonats { get; set; }
    }
}
