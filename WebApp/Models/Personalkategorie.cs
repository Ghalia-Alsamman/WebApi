using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalkategorie
    {
        public Personalkategorie()
        {
            Mitarbeiters = new HashSet<Mitarbeiter>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Mitarbeiter> Mitarbeiters { get; set; }
    }
}
