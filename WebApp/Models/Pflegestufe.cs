using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Pflegestufe
    {
        public Pflegestufe()
        {
            KostenstellePflegestuves = new HashSet<KostenstellePflegestufe>();
            SachkontoProzentBetriebsstaettes = new HashSet<SachkontoProzentBetriebsstaette>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Propertybezeichnung { get; set; }

        public virtual ICollection<KostenstellePflegestufe> KostenstellePflegestuves { get; set; }
        public virtual ICollection<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
    }
}
