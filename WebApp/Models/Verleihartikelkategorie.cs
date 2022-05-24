using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verleihartikelkategorie
    {
        public Verleihartikelkategorie()
        {
            Verleihartikels = new HashSet<Verleihartikel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Verleihartikel> Verleihartikels { get; set; }
    }
}
