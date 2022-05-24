using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Schwund
    {
        public Schwund()
        {
            Bestands = new HashSet<Bestand>();
            SchwundLagerArtikels = new HashSet<SchwundLagerArtikel>();
        }

        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Bestand> Bestands { get; set; }
        public virtual ICollection<SchwundLagerArtikel> SchwundLagerArtikels { get; set; }
    }
}
