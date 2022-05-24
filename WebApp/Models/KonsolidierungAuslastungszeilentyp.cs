using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungAuslastungszeilentyp
    {
        public KonsolidierungAuslastungszeilentyp()
        {
            KonsolidierungAuslastungszeiles = new HashSet<KonsolidierungAuslastungszeile>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? KonsolidierungAuslastungsblocktypId { get; set; }

        public virtual KonsolidierungAuslastungsblocktyp KonsolidierungAuslastungsblocktyp { get; set; }
        public virtual ICollection<KonsolidierungAuslastungszeile> KonsolidierungAuslastungszeiles { get; set; }
    }
}
