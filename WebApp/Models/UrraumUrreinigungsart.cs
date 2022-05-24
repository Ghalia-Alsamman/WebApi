using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class UrraumUrreinigungsart
    {
        public int Id { get; set; }
        public int UrRaumId { get; set; }
        public int URreinigungsartId { get; set; }
        public int Tag { get; set; }
        public int Anzahl { get; set; }

        public virtual Urreinigungsart URreinigungsart { get; set; }
        public virtual Urraum UrRaum { get; set; }
    }
}
