using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class StrategischeKalkulation
    {
        public StrategischeKalkulation()
        {
            StrategischeKalkulationKalkulations = new HashSet<StrategischeKalkulationKalkulation>();
            StrategischeKalkulationKonsolidierungs = new HashSet<StrategischeKalkulationKonsolidierung>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? KalkulationsartId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string Notiz { get; set; }
        public bool Aktiv { get; set; }
        public bool BasisKonsolidierung { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kalkulationsart Kalkulationsart { get; set; }
        public virtual ICollection<StrategischeKalkulationKalkulation> StrategischeKalkulationKalkulations { get; set; }
        public virtual ICollection<StrategischeKalkulationKonsolidierung> StrategischeKalkulationKonsolidierungs { get; set; }
    }
}
