using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class GuvSummenzeile
    {
        public GuvSummenzeile()
        {
            SachkontengruppeGuvSummenzeiles = new HashSet<SachkontengruppeGuvSummenzeile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HinterSachkontengruppeId { get; set; }
        public int? Reihenfolge { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Sachkontengruppe HinterSachkontengruppe { get; set; }
        public virtual ICollection<SachkontengruppeGuvSummenzeile> SachkontengruppeGuvSummenzeiles { get; set; }
    }
}
