using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontenGliederungsgruppe
    {
        public SachkontenGliederungsgruppe()
        {
            InverseOberGliederung = new HashSet<SachkontenGliederungsgruppe>();
            SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles = new HashSet<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile>();
            SachkontoGliederungsgruppeSummenzeiles = new HashSet<SachkontoGliederungsgruppeSummenzeile>();
            SachkontoSachkontoGliederungsgruppes = new HashSet<SachkontoSachkontoGliederungsgruppe>();
        }

        public int Id { get; set; }
        public int? OberGliederungId { get; set; }
        public string Name { get; set; }
        public int Reihenfolge { get; set; }
        public string PositionString { get; set; }
        public bool? IstGuVposition { get; set; }
        public bool? Aktiv { get; set; }
        public int? Typ { get; set; }

        public virtual SachkontenGliederungsgruppe OberGliederung { get; set; }
        public virtual ICollection<SachkontenGliederungsgruppe> InverseOberGliederung { get; set; }
        public virtual ICollection<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile> SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles { get; set; }
        public virtual ICollection<SachkontoGliederungsgruppeSummenzeile> SachkontoGliederungsgruppeSummenzeiles { get; set; }
        public virtual ICollection<SachkontoSachkontoGliederungsgruppe> SachkontoSachkontoGliederungsgruppes { get; set; }
    }
}
