using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class FaktorenPvist
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int PersonalfaktorId { get; set; }
        public double? Faktor { get; set; }
        public bool InKalkulationEnthalten { get; set; }
        public DateTime GueltigBis { get; set; }
        public bool Aktiv { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Personalfaktor Personalfaktor { get; set; }
    }
}
