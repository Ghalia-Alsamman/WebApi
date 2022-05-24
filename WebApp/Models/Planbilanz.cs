using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Planbilanz
    {
        public Planbilanz()
        {
            InverseVorjahresbilanz = new HashSet<Planbilanz>();
            PlanbilanzKonsolidierungPlanbilanzkonsolidierungs = new HashSet<PlanbilanzKonsolidierung>();
            PlanbilanzKonsolidierungPlanbilanzs = new HashSet<PlanbilanzKonsolidierung>();
            PlanbilanzMittelfristplanungPositions = new HashSet<PlanbilanzMittelfristplanungPosition>();
            PlanbilanzPositions = new HashSet<PlanbilanzPosition>();
        }

        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? KalkulationId { get; set; }
        public DateTime DatumVon { get; set; }
        public DateTime DatumBis { get; set; }
        public bool? Aktiv { get; set; }
        public int? BenutzerId { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? Istdatum { get; set; }
        public int? VorjahresbilanzId { get; set; }
        public string Planalternative { get; set; }
        public string Bezeichnung { get; set; }
        public int? Typ { get; set; }
        public int? KonsolidierungId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Planbilanz Vorjahresbilanz { get; set; }
        public virtual ICollection<Planbilanz> InverseVorjahresbilanz { get; set; }
        public virtual ICollection<PlanbilanzKonsolidierung> PlanbilanzKonsolidierungPlanbilanzkonsolidierungs { get; set; }
        public virtual ICollection<PlanbilanzKonsolidierung> PlanbilanzKonsolidierungPlanbilanzs { get; set; }
        public virtual ICollection<PlanbilanzMittelfristplanungPosition> PlanbilanzMittelfristplanungPositions { get; set; }
        public virtual ICollection<PlanbilanzPosition> PlanbilanzPositions { get; set; }
    }
}
