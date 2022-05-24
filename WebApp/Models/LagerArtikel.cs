using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class LagerArtikel
    {
        public LagerArtikel()
        {
            BestandLagerArtikels = new HashSet<BestandLagerArtikel>();
            Bestandsbewegungs = new HashSet<Bestandsbewegung>();
            BestellungLagerArtikels = new HashSet<BestellungLagerArtikel>();
            InventurLagerArtikels = new HashSet<InventurLagerArtikel>();
            SchwundLagerArtikels = new HashSet<SchwundLagerArtikel>();
            TransferArtikels = new HashSet<TransferArtikel>();
        }

        public int Id { get; set; }
        public int? LagerId { get; set; }
        public int? ArtikelId { get; set; }
        public int? BestandId { get; set; }
        public double? Menge { get; set; }
        public double? Sollmenge { get; set; }
        public double? Durchschnittspreis { get; set; }
        public bool? IstInventur { get; set; }
        public string InterneBelegnummer { get; set; }
        public bool IstBarkauf { get; set; }
        public string ErklaerungAbweichungInventur { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Bestand Bestand { get; set; }
        public virtual Lager Lager { get; set; }
        public virtual ICollection<BestandLagerArtikel> BestandLagerArtikels { get; set; }
        public virtual ICollection<Bestandsbewegung> Bestandsbewegungs { get; set; }
        public virtual ICollection<BestellungLagerArtikel> BestellungLagerArtikels { get; set; }
        public virtual ICollection<InventurLagerArtikel> InventurLagerArtikels { get; set; }
        public virtual ICollection<SchwundLagerArtikel> SchwundLagerArtikels { get; set; }
        public virtual ICollection<TransferArtikel> TransferArtikels { get; set; }
    }
}
