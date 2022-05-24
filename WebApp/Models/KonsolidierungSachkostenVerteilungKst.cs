using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungSachkostenVerteilungKst
    {
        public int Id { get; set; }
        public int? KonsolidierungSachkostenzeileId { get; set; }
        public int? KonsolidierungImportVorjahrId { get; set; }
        public int? KostenstelleId { get; set; }
        public double ProzentKostenstelle { get; set; }

        public virtual KonsolidierungImportVorjahr KonsolidierungImportVorjahr { get; set; }
        public virtual KonsolidierungSachkostenzeile KonsolidierungSachkostenzeile { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
    }
}
