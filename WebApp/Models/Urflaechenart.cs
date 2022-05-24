using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urflaechenart
    {
        public Urflaechenart()
        {
            Urraums = new HashSet<Urraum>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Urraum> Urraums { get; set; }
    }
}
