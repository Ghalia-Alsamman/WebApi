using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewDateiverknuepfung
    {
        public int Id { get; set; }
        public int DateiId { get; set; }
        public int? DateiartId { get; set; }
        public int? BenutzerId { get; set; }
        public string Dateiname { get; set; }
        public string Dateierweiterung { get; set; }
        public string DateiAuthor { get; set; }
        public double Dateigroesse { get; set; }
        public byte[] Dateiinhalt { get; set; }
        public string Dateiart { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Benutzername { get; set; }
        public string Verknuepfungsklasse { get; set; }
        public int VerknuepfungsklassenId { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public bool IstVeroeffentlicht { get; set; }
    }
}
