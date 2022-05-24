using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Dateivorlage
    {
        public Dateivorlage()
        {
            Angebots = new HashSet<Angebot>();
        }

        public int Id { get; set; }
        public int? Benutzerid { get; set; }
        public int? Vorlagenartid { get; set; }
        public string Name { get; set; }
        public string Typ { get; set; }
        public byte[] Datei { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Vorlagenart Vorlagenart { get; set; }
        public virtual ICollection<Angebot> Angebots { get; set; }
    }
}
