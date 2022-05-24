using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Loesung
    {
        public Loesung()
        {
            KundeLoesungs = new HashSet<KundeLoesung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<KundeLoesung> KundeLoesungs { get; set; }
    }
}
