using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verprobungsfaktor
    {
        public Verprobungsfaktor()
        {
            Berufsgruppes = new HashSet<Berufsgruppe>();
            BetriebsstaetteVerprobungsfaktors = new HashSet<BetriebsstaetteVerprobungsfaktor>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public bool AutomatischeBerechnung { get; set; }
        public bool? Aktiv { get; set; }
        public decimal KapaFaktor { get; set; }

        public virtual ICollection<Berufsgruppe> Berufsgruppes { get; set; }
        public virtual ICollection<BetriebsstaetteVerprobungsfaktor> BetriebsstaetteVerprobungsfaktors { get; set; }
    }
}
