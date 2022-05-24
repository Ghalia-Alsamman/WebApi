using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Land
    {
        public Land()
        {
            Adresses = new HashSet<Adresse>();
            Mitgliedsbeitrags = new HashSet<Mitgliedsbeitrag>();
            Postleitzahlenvorgabewertes = new HashSet<Postleitzahlenvorgabewerte>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Adresse> Adresses { get; set; }
        public virtual ICollection<Mitgliedsbeitrag> Mitgliedsbeitrags { get; set; }
        public virtual ICollection<Postleitzahlenvorgabewerte> Postleitzahlenvorgabewertes { get; set; }
    }
}
