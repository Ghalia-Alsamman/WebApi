using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DarlehenTypen
    {
        public DarlehenTypen()
        {
            Betriebsstaettedarlehens = new HashSet<Betriebsstaettedarlehen>();
            Darlehens = new HashSet<Darlehen>();
            KonsolidierungDarlehens = new HashSet<KonsolidierungDarlehen>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? PlanbilanzkontoId { get; set; }
        public int? PlanbilanzgegenkontoId { get; set; }
        public int? AbgrenzungzinsenId { get; set; }
        public int? AbgrenzungtilgungId { get; set; }
        public int? SachkontoId { get; set; }

        public virtual Sachkonto Abgrenzungtilgung { get; set; }
        public virtual Sachkonto Abgrenzungzinsen { get; set; }
        public virtual Planbilanzkonto Planbilanzgegenkonto { get; set; }
        public virtual Planbilanzkonto Planbilanzkonto { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> Betriebsstaettedarlehens { get; set; }
        public virtual ICollection<Darlehen> Darlehens { get; set; }
        public virtual ICollection<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
    }
}
