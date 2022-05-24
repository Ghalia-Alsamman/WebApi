using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungKomponente
    {
        public BerechtigungKomponente()
        {
            BerechtigungKomponenteBerechtigungs = new HashSet<BerechtigungKomponenteBerechtigung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BerechtigungKomponenteBerechtigung> BerechtigungKomponenteBerechtigungs { get; set; }
    }
}
