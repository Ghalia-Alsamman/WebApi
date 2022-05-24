using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sonderzahlungen
    {
        public Sonderzahlungen()
        {
            KonsolidierungPraemies = new HashSet<KonsolidierungPraemie>();
            Praemies = new HashSet<Praemie>();
            TarifBerufsgruppes = new HashSet<TarifBerufsgruppe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Auswerten { get; set; }
        public bool SvBefreit { get; set; }
        public bool? Aktiv { get; set; }
        public int Sortierung { get; set; }
        public int? AbgrenzungskontoId { get; set; }

        public virtual Sachkonto Abgrenzungskonto { get; set; }
        public virtual ICollection<KonsolidierungPraemie> KonsolidierungPraemies { get; set; }
        public virtual ICollection<Praemie> Praemies { get; set; }
        public virtual ICollection<TarifBerufsgruppe> TarifBerufsgruppes { get; set; }
    }
}
