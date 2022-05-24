using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urleistungswerte
    {
        public Urleistungswerte()
        {
            UrraumnutzgruppeKalkulations = new HashSet<UrraumnutzgruppeKalkulation>();
            Urraumnutzgruppes = new HashSet<Urraumnutzgruppe>();
        }

        public int Id { get; set; }
        public double? Montag { get; set; }
        public double? Dienstag { get; set; }
        public double? Mittwoch { get; set; }
        public double? Donnerstag { get; set; }
        public double? Freitag { get; set; }
        public double? Samstag { get; set; }
        public double? Sonntag { get; set; }

        public virtual ICollection<UrraumnutzgruppeKalkulation> UrraumnutzgruppeKalkulations { get; set; }
        public virtual ICollection<Urraumnutzgruppe> Urraumnutzgruppes { get; set; }
    }
}
