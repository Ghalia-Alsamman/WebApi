using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKalkulationenFuerFinanzplanung
    {
        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }
        public bool Deaktiviert { get; set; }
    }
}
