using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Datei
    {
        public Datei()
        {
            Dateiverknuepfungs = new HashSet<Dateiverknuepfung>();
        }

        public int Id { get; set; }
        public int? BenutzerId { get; set; }
        public int? DateiartId { get; set; }
        public string NameHash { get; set; }
        public string Dateiname { get; set; }
        public string Dateierweiterung { get; set; }
        public string DateiAuthor { get; set; }
        public double Dateigroesse { get; set; }
        public byte[] Dateiinhalt { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool IstVeroeffentlicht { get; set; }
        public bool KannVeroeffentlichtWerden { get; set; }
        public DateTime? OeffentlichBis { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Dateiart Dateiart { get; set; }
        public virtual ICollection<Dateiverknuepfung> Dateiverknuepfungs { get; set; }
    }
}
