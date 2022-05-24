using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BestellObjektStatus
    {
        public BestellObjektStatus()
        {
            BestellObjekts = new HashSet<BestellObjekt>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public int? Kennziffer { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<BestellObjekt> BestellObjekts { get; set; }
    }
}
