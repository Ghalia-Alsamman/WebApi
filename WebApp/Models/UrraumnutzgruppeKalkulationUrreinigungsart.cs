using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class UrraumnutzgruppeKalkulationUrreinigungsart
    {
        public int Id { get; set; }
        public int URreinigungsartId { get; set; }
        public int URraumnutzgruppeKalkulationId { get; set; }
        public double Faktor { get; set; }

        public virtual UrraumnutzgruppeKalkulation URraumnutzgruppeKalkulation { get; set; }
        public virtual Urreinigungsart URreinigungsart { get; set; }
    }
}
