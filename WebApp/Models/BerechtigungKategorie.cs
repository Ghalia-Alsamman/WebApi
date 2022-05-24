using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungKategorie
    {
        public BerechtigungKategorie()
        {
            Berechtigungs = new HashSet<Berechtigung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Berechtigung> Berechtigungs { get; set; }
    }
}
