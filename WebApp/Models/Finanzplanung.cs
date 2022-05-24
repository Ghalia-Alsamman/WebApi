using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Finanzplanung
    {
        public Finanzplanung()
        {
            Darlehens = new HashSet<Darlehen>();
            KonsolidierungDarlehens = new HashSet<KonsolidierungDarlehen>();
            LiquiditaetsplanungZeiles = new HashSet<LiquiditaetsplanungZeile>();
        }

        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int? BenutzerId { get; set; }
        public int? KalkulationId { get; set; }
        public string Name { get; set; }
        public double? AnfangsKontostandLiqPl { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? IstAbgeschlossen { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual ICollection<Darlehen> Darlehens { get; set; }
        public virtual ICollection<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
        public virtual ICollection<LiquiditaetsplanungZeile> LiquiditaetsplanungZeiles { get; set; }
    }
}
