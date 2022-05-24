using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Lizenz
    {
        public Lizenz()
        {
            BenutzerLizenzs = new HashSet<BenutzerLizenz>();
        }

        public int Id { get; set; }
        public string Modul { get; set; }
        public string Lizenz1 { get; set; }
        public string Bezeichnung { get; set; }
        public bool IstCoreLizenz { get; set; }
        public bool KannZugeordnetWerden { get; set; }

        public virtual ICollection<BenutzerLizenz> BenutzerLizenzs { get; set; }
    }
}
