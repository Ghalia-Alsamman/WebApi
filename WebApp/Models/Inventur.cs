using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Inventur
    {
        public Inventur()
        {
            InventurLagerArtikels = new HashSet<InventurLagerArtikel>();
        }

        public int Id { get; set; }
        public int LagerId { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Sollinventurdatum { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Lager Lager { get; set; }
        public virtual ICollection<InventurLagerArtikel> InventurLagerArtikels { get; set; }
    }
}
