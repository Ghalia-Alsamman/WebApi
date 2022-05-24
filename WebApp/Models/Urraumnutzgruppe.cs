using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urraumnutzgruppe
    {
        public Urraumnutzgruppe()
        {
            UrraumnutzgruppeKalkulations = new HashSet<UrraumnutzgruppeKalkulation>();
        }

        public int Id { get; set; }
        public int? UrRaumnutzkategorieId { get; set; }
        public int? URleistungswerteId { get; set; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public bool Aktiv { get; set; }

        public virtual Urleistungswerte URleistungswerte { get; set; }
        public virtual Urraumnutzkategorie UrRaumnutzkategorie { get; set; }
        public virtual ICollection<UrraumnutzgruppeKalkulation> UrraumnutzgruppeKalkulations { get; set; }
    }
}
