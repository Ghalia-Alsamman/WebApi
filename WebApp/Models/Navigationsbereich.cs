using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Navigationsbereich
    {
        public Navigationsbereich()
        {
            BenutzerUebersichts = new HashSet<BenutzerUebersicht>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Typ { get; set; }

        public virtual ICollection<BenutzerUebersicht> BenutzerUebersichts { get; set; }
    }
}
