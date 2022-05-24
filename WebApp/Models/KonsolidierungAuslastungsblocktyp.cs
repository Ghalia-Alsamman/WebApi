using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungAuslastungsblocktyp
    {
        public KonsolidierungAuslastungsblocktyp()
        {
            KonsolidierungAuslastungsblocks = new HashSet<KonsolidierungAuslastungsblock>();
            KonsolidierungAuslastungszeilentyps = new HashSet<KonsolidierungAuslastungszeilentyp>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? Reihenfolge { get; set; }

        public virtual ICollection<KonsolidierungAuslastungsblock> KonsolidierungAuslastungsblocks { get; set; }
        public virtual ICollection<KonsolidierungAuslastungszeilentyp> KonsolidierungAuslastungszeilentyps { get; set; }
    }
}
