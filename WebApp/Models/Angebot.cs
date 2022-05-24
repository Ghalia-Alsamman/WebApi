using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Angebot
    {
        public Angebot()
        {
            KalkulationAngebots = new HashSet<KalkulationAngebot>();
        }

        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? DateivorlageId { get; set; }
        public int? KalkulationId { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public bool? IstEmpfaenger { get; set; }
        public bool? IstVersendet { get; set; }
        public DateTime? FristBis { get; set; }
        public bool? IstVertrag { get; set; }
        public DateTime? LaufzeitVon { get; set; }
        public DateTime? LaufzeitBis { get; set; }
        public string Nachricht { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Dateivorlage Dateivorlage { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual ICollection<KalkulationAngebot> KalkulationAngebots { get; set; }
    }
}
