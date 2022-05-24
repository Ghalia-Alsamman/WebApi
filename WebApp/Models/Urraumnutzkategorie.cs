using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urraumnutzkategorie
    {
        public Urraumnutzkategorie()
        {
            Urraumnutzgruppes = new HashSet<Urraumnutzgruppe>();
            UrraumnutzkategorieKalkulations = new HashSet<UrraumnutzkategorieKalkulation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public bool? Standard { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Urraumnutzgruppe> Urraumnutzgruppes { get; set; }
        public virtual ICollection<UrraumnutzkategorieKalkulation> UrraumnutzkategorieKalkulations { get; set; }
    }
}
