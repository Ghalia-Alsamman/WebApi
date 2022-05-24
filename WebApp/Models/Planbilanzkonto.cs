using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Planbilanzkonto
    {
        public Planbilanzkonto()
        {
            AnlageartAktuellPlanbilanzgegenkontos = new HashSet<Anlageart>();
            AnlageartAktuellPlanbilanzkontos = new HashSet<Anlageart>();
            AnlageartPlanbilanzgegenkontos = new HashSet<Anlageart>();
            AnlageartPlanbilanzkontos = new HashSet<Anlageart>();
            DarlehenTypenPlanbilanzgegenkontos = new HashSet<DarlehenTypen>();
            DarlehenTypenPlanbilanzkontos = new HashSet<DarlehenTypen>();
            InverseNegativparent = new HashSet<Planbilanzkonto>();
            InverseParent = new HashSet<Planbilanzkonto>();
            PlanbilanzPositionPlanbilanzgegenkontos = new HashSet<PlanbilanzPosition>();
            PlanbilanzPositionPlanbilanzkontos = new HashSet<PlanbilanzPosition>();
            SachkontoPlanbilanzgegenkontos = new HashSet<Sachkonto>();
            SachkontoPlanbilanzkontos = new HashSet<Sachkonto>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Diamantkonto { get; set; }
        public string Diamantplankonto { get; set; }
        public bool AutoSumme { get; set; }
        public bool? KontoArt { get; set; }
        public int Sortierung { get; set; }
        public string Gliederung { get; set; }
        public bool Bearbeitbar { get; set; }
        public bool? Sichtbar { get; set; }
        public bool? Aktiv { get; set; }
        public bool Gewinn { get; set; }
        public bool Umlauf { get; set; }
        public int? NegativparentId { get; set; }

        public virtual Planbilanzkonto Negativparent { get; set; }
        public virtual Planbilanzkonto Parent { get; set; }
        public virtual ICollection<Anlageart> AnlageartAktuellPlanbilanzgegenkontos { get; set; }
        public virtual ICollection<Anlageart> AnlageartAktuellPlanbilanzkontos { get; set; }
        public virtual ICollection<Anlageart> AnlageartPlanbilanzgegenkontos { get; set; }
        public virtual ICollection<Anlageart> AnlageartPlanbilanzkontos { get; set; }
        public virtual ICollection<DarlehenTypen> DarlehenTypenPlanbilanzgegenkontos { get; set; }
        public virtual ICollection<DarlehenTypen> DarlehenTypenPlanbilanzkontos { get; set; }
        public virtual ICollection<Planbilanzkonto> InverseNegativparent { get; set; }
        public virtual ICollection<Planbilanzkonto> InverseParent { get; set; }
        public virtual ICollection<PlanbilanzPosition> PlanbilanzPositionPlanbilanzgegenkontos { get; set; }
        public virtual ICollection<PlanbilanzPosition> PlanbilanzPositionPlanbilanzkontos { get; set; }
        public virtual ICollection<Sachkonto> SachkontoPlanbilanzgegenkontos { get; set; }
        public virtual ICollection<Sachkonto> SachkontoPlanbilanzkontos { get; set; }
    }
}
