using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Einheit
    {
        public Einheit()
        {
            InverseVaterEinheit = new HashSet<Einheit>();
            Kennzahls = new HashSet<Kennzahl>();
        }

        public int Id { get; set; }
        public int? VaterEinheitId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Beschreibung { get; set; }
        public double? UmrechnungsfaktorZuVater { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Einheit VaterEinheit { get; set; }
        public virtual ICollection<Einheit> InverseVaterEinheit { get; set; }
        public virtual ICollection<Kennzahl> Kennzahls { get; set; }
    }
}
