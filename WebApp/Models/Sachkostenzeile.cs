using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkostenzeile
    {
        public Sachkostenzeile()
        {
            SachkostenVerteilungKsts = new HashSet<SachkostenVerteilungKst>();
        }

        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int SachkontoId { get; set; }
        public string Name { get; set; }
        public DateTime? Datum { get; set; }
        public double? IstVorjahrWert { get; set; }
        public bool IstSkalierenderWert { get; set; }
        public double SkalierenderWert { get; set; }
        public double? HochgerechneterLfdJahr { get; set; }
        public double? PlanWert { get; set; }
        public double? PlanJanuar { get; set; }
        public double? PlanFebruar { get; set; }
        public double? PlanMaerz { get; set; }
        public double? PlanApril { get; set; }
        public double? PlanMai { get; set; }
        public double? PlanJuni { get; set; }
        public double? PlanJuli { get; set; }
        public double? PlanAugust { get; set; }
        public double? PlanSeptember { get; set; }
        public double? PlanOktober { get; set; }
        public double? PlanNovember { get; set; }
        public double? PlanDezember { get; set; }
        public bool? Monatsgenau { get; set; }
        public byte[] Nebenrechnung { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual ICollection<SachkostenVerteilungKst> SachkostenVerteilungKsts { get; set; }
    }
}
