using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class RegionaleZuordnung
    {
        public RegionaleZuordnung()
        {
            Benutzers = new HashSet<Benutzer>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
            Konsolidierungs = new HashSet<Konsolidierung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Benutzer> Benutzers { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual ICollection<Konsolidierung> Konsolidierungs { get; set; }
    }
}
