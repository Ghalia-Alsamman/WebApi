using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class UrraumnutzkategorieKalkulation
    {
        public UrraumnutzkategorieKalkulation()
        {
            UrraumnutzgruppeKalkulations = new HashSet<UrraumnutzgruppeKalkulation>();
        }

        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int URraumnutzkategorieId { get; set; }
        public double Faktor { get; set; }
        public string Bemerkung { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Urraumnutzkategorie URraumnutzkategorie { get; set; }
        public virtual ICollection<UrraumnutzgruppeKalkulation> UrraumnutzgruppeKalkulations { get; set; }
    }
}
