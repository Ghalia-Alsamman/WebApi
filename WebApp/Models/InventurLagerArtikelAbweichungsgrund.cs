using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class InventurLagerArtikelAbweichungsgrund
    {
        public InventurLagerArtikelAbweichungsgrund()
        {
            InventurLagerArtikels = new HashSet<InventurLagerArtikel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<InventurLagerArtikel> InventurLagerArtikels { get; set; }
    }
}
