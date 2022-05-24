using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersichtBasis
    {
        public BenutzerUebersichtBasis()
        {
            BenutzerUebersichts = new HashSet<BenutzerUebersicht>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Viewname { get; set; }
        public string Typ { get; set; }
        public string OeffneModul { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<BenutzerUebersicht> BenutzerUebersichts { get; set; }
    }
}
