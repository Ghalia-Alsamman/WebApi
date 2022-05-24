using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Anlageart
    {
        public Anlageart()
        {
            AfAzeiles = new HashSet<AfAzeile>();
            KonsolidierungAfAzeiles = new HashSet<KonsolidierungAfAzeile>();
        }

        public int Id { get; set; }
        public int AnlagegruppeId { get; set; }
        public string Name { get; set; }
        public int? AfaLaufzeit { get; set; }
        public double? Nettopreis { get; set; }
        public bool Aktiv { get; set; }
        public int? PlanbilanzkontoId { get; set; }
        public int? PlanbilanzgegenkontoId { get; set; }
        public int? AktuellPlanbilanzkontoId { get; set; }
        public int? AktuellPlanbilanzgegenkontoId { get; set; }

        public virtual Planbilanzkonto AktuellPlanbilanzgegenkonto { get; set; }
        public virtual Planbilanzkonto AktuellPlanbilanzkonto { get; set; }
        public virtual Anlagengruppe Anlagegruppe { get; set; }
        public virtual Planbilanzkonto Planbilanzgegenkonto { get; set; }
        public virtual Planbilanzkonto Planbilanzkonto { get; set; }
        public virtual ICollection<AfAzeile> AfAzeiles { get; set; }
        public virtual ICollection<KonsolidierungAfAzeile> KonsolidierungAfAzeiles { get; set; }
    }
}
