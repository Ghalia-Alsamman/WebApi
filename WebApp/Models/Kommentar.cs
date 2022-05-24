using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kommentar
    {
        public Kommentar()
        {
            Auftrags = new HashSet<Auftrag>();
            Kundes = new HashSet<Kunde>();
            Lieferants = new HashSet<Lieferant>();
            Menueplans = new HashSet<Menueplan>();
            Rezepts = new HashSet<Rezept>();
        }

        public int Id { get; set; }
        public string Nachricht { get; set; }

        public virtual ICollection<Auftrag> Auftrags { get; set; }
        public virtual ICollection<Kunde> Kundes { get; set; }
        public virtual ICollection<Lieferant> Lieferants { get; set; }
        public virtual ICollection<Menueplan> Menueplans { get; set; }
        public virtual ICollection<Rezept> Rezepts { get; set; }
    }
}
