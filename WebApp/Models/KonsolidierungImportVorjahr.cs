using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungImportVorjahr
    {
        public KonsolidierungImportVorjahr()
        {
            KonsolidierungSachkostenVerteilungKsts = new HashSet<KonsolidierungSachkostenVerteilungKst>();
        }

        public int Id { get; set; }
        public int KonsolidierungId { get; set; }
        public int SachkontoId { get; set; }
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
        public double? VorjahrGesamtsumme { get; set; }

        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual ICollection<KonsolidierungSachkostenVerteilungKst> KonsolidierungSachkostenVerteilungKsts { get; set; }
    }
}
