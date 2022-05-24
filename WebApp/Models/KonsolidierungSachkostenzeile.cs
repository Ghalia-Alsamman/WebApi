using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungSachkostenzeile
    {
        public KonsolidierungSachkostenzeile()
        {
            KonsolidierungSachkostenVerteilungKsts = new HashSet<KonsolidierungSachkostenVerteilungKst>();
        }

        public int Id { get; set; }
        public int KonsolidierungId { get; set; }
        public int SachkontoId { get; set; }
        public double? Planwert { get; set; }
        public double? IstVorjahrWert { get; set; }
        public double? HochgerechneterLfdJahr { get; set; }
        public double? ErrechneterWert { get; set; }

        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual ICollection<KonsolidierungSachkostenVerteilungKst> KonsolidierungSachkostenVerteilungKsts { get; set; }
    }
}
