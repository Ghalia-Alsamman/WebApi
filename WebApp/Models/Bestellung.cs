using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bestellung
    {
        public Bestellung()
        {
            BestellungLagerArtikels = new HashSet<BestellungLagerArtikel>();
        }

        public int Id { get; set; }
        public int? BenutzerId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string Bestellnummer { get; set; }
        public string Rechnungsnummer { get; set; }
        public DateTime? Bestelldatum { get; set; }
        public DateTime? Lieferdatum { get; set; }
        public bool IstBarkauf { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
        public virtual ICollection<BestellungLagerArtikel> BestellungLagerArtikels { get; set; }
    }
}
