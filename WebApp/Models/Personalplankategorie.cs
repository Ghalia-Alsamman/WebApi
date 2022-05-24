using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalplankategorie
    {
        public Personalplankategorie()
        {
            Personalplans = new HashSet<Personalplan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Personalplan> Personalplans { get; set; }
    }
}
