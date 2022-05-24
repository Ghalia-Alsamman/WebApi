using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kostenbereich
    {
        public Kostenbereich()
        {
            KostenstelleVorgabenames = new HashSet<KostenstelleVorgabename>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<KostenstelleVorgabename> KostenstelleVorgabenames { get; set; }
    }
}
