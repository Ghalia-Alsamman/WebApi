using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sonderveranstaltung
    {
        public Sonderveranstaltung()
        {
            SonderveranstaltungArtikels = new HashSet<SonderveranstaltungArtikel>();
            SonderveranstaltungPersonals = new HashSet<SonderveranstaltungPersonal>();
        }

        public int Id { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }
        public int? AdresseId { get; set; }
        public DateTime? Ausrichtungsdatum { get; set; }
        public double? AnzahlPersonen { get; set; }
        public string Thema { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public string Deko { get; set; }
        public string Bemerkung { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
        public virtual ICollection<SonderveranstaltungArtikel> SonderveranstaltungArtikels { get; set; }
        public virtual ICollection<SonderveranstaltungPersonal> SonderveranstaltungPersonals { get; set; }
    }
}
