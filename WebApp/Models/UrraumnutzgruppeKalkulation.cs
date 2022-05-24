using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class UrraumnutzgruppeKalkulation
    {
        public UrraumnutzgruppeKalkulation()
        {
            UrraumnutzgruppeKalkulationUrreinigungsarts = new HashSet<UrraumnutzgruppeKalkulationUrreinigungsart>();
            Urraums = new HashSet<Urraum>();
        }

        public int Id { get; set; }
        public int URraumnutzgruppeId { get; set; }
        public int URraumnutzkategorieKalkulationId { get; set; }
        public int URleistungswerteId { get; set; }
        public string Bemerkung { get; set; }

        public virtual Urleistungswerte URleistungswerte { get; set; }
        public virtual Urraumnutzgruppe URraumnutzgruppe { get; set; }
        public virtual UrraumnutzkategorieKalkulation URraumnutzkategorieKalkulation { get; set; }
        public virtual ICollection<UrraumnutzgruppeKalkulationUrreinigungsart> UrraumnutzgruppeKalkulationUrreinigungsarts { get; set; }
        public virtual ICollection<Urraum> Urraums { get; set; }
    }
}
