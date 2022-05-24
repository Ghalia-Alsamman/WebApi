using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urraum
    {
        public Urraum()
        {
            UrraumUrreinigungsarts = new HashSet<UrraumUrreinigungsart>();
        }

        public int Id { get; set; }
        public int? URraumnutzgruppeKalkulationId { get; set; }
        public int KalkulationId { get; set; }
        public int? RhythmusId { get; set; }
        public int? DinnormId { get; set; }
        public int? UrflaechenartId { get; set; }
        public double? Flaeche { get; set; }
        public string Name { get; set; }
        public string Raumnummer { get; set; }
        public string Allgemeinflaeche { get; set; }
        public string Etage { get; set; }
        public string Reinigungskraft { get; set; }
        public string Schluessel { get; set; }
        public string Bereich { get; set; }
        public string Bemerkungen { get; set; }

        public virtual Dinnorm Dinnorm { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Rhythmu Rhythmus { get; set; }
        public virtual UrraumnutzgruppeKalkulation URraumnutzgruppeKalkulation { get; set; }
        public virtual Urflaechenart Urflaechenart { get; set; }
        public virtual ICollection<UrraumUrreinigungsart> UrraumUrreinigungsarts { get; set; }
    }
}
