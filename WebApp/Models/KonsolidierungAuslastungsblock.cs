using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungAuslastungsblock
    {
        public KonsolidierungAuslastungsblock()
        {
            KonsolidierungAuslastungszeiles = new HashSet<KonsolidierungAuslastungszeile>();
        }

        public int Id { get; set; }
        public int KonsolidierungId { get; set; }
        public int AuslastungsartId { get; set; }
        public int? TypId { get; set; }
        public double? WertJanuar { get; set; }
        public double? WertFebruar { get; set; }
        public double? WertMaerz { get; set; }
        public double? WertApril { get; set; }
        public double? WertMai { get; set; }
        public double? WertJuni { get; set; }
        public double? WertJuli { get; set; }
        public double? WertAugust { get; set; }
        public double? WertSeptember { get; set; }
        public double? WertOktober { get; set; }
        public double? WertNovember { get; set; }
        public double? WertDezember { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual KonsolidierungAuslastungsblocktyp Typ { get; set; }
        public virtual ICollection<KonsolidierungAuslastungszeile> KonsolidierungAuslastungszeiles { get; set; }
    }
}
