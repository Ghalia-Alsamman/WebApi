using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urlaubsart
    {
        public Urlaubsart()
        {
            Urlaubs = new HashSet<Urlaub>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Urlaub> Urlaubs { get; set; }
    }
}
