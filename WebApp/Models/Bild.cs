using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bild
    {
        public Bild()
        {
            Rezepts = new HashSet<Rezept>();
        }

        public int Id { get; set; }
        public byte[] Bild1 { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Rezept> Rezepts { get; set; }
    }
}
