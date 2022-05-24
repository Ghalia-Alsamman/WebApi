using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Menueplankategorie
    {
        public Menueplankategorie()
        {
            Menueplans = new HashSet<Menueplan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Menueplan> Menueplans { get; set; }
    }
}
