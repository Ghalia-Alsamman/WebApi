using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkostenVerteilungKst
    {
        public int Id { get; set; }
        public int? SachkostenzeileId { get; set; }
        public int? ImportSachkostenId { get; set; }
        public int? KostenstelleId { get; set; }
        public double ProzentKostenstelle { get; set; }

        public virtual ImportSachkosten ImportSachkosten { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkostenzeile Sachkostenzeile { get; set; }
    }
}
