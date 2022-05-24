using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class RezeptPortionsgroesse
    {
        public RezeptPortionsgroesse()
        {
            Rezepts = new HashSet<Rezept>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Rezept> Rezepts { get; set; }
    }
}
