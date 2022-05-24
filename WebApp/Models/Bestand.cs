using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bestand
    {
        public Bestand()
        {
            BestandLagerArtikels = new HashSet<BestandLagerArtikel>();
            LagerArtikels = new HashSet<LagerArtikel>();
        }

        public int Id { get; set; }
        public int? LagerId { get; set; }
        public int? SchwundId { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? Sollinventurdatum { get; set; }
        public DateTime? Abschlussdatum { get; set; }
        public bool? IstInventur { get; set; }
        public bool? IstAbgeschlossen { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Lager Lager { get; set; }
        public virtual Schwund Schwund { get; set; }
        public virtual ICollection<BestandLagerArtikel> BestandLagerArtikels { get; set; }
        public virtual ICollection<LagerArtikel> LagerArtikels { get; set; }
    }
}
