using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Anlagengruppe
    {
        public Anlagengruppe()
        {
            Anlagearts = new HashSet<Anlageart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Anlageart> Anlagearts { get; set; }
    }
}
