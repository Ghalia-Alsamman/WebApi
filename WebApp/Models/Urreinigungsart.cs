using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urreinigungsart
    {
        public Urreinigungsart()
        {
            UrraumUrreinigungsarts = new HashSet<UrraumUrreinigungsart>();
            UrraumnutzgruppeKalkulationUrreinigungsarts = new HashSet<UrraumnutzgruppeKalkulationUrreinigungsart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Kuerzel { get; set; }
        public double? Faktor { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<UrraumUrreinigungsart> UrraumUrreinigungsarts { get; set; }
        public virtual ICollection<UrraumnutzgruppeKalkulationUrreinigungsart> UrraumnutzgruppeKalkulationUrreinigungsarts { get; set; }
    }
}
