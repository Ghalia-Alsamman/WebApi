using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontoGliederungsgruppeSummenzeile
    {
        public SachkontoGliederungsgruppeSummenzeile()
        {
            SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles = new HashSet<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile>();
        }

        public int Id { get; set; }
        public int HinterSachkontoGliederungsgruppeId { get; set; }
        public string Name { get; set; }
        public int Reihenfolge { get; set; }
        public bool? Aktiv { get; set; }

        public virtual SachkontenGliederungsgruppe HinterSachkontoGliederungsgruppe { get; set; }
        public virtual ICollection<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile> SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles { get; set; }
    }
}
