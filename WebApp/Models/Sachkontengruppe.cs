using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkontengruppe
    {
        public Sachkontengruppe()
        {
            Buchungstags = new HashSet<Buchungstag>();
            GuvSummenzeiles = new HashSet<GuvSummenzeile>();
            InverseOberSachkontengruppe = new HashSet<Sachkontengruppe>();
            SachkontengruppeGuvSummenzeiles = new HashSet<SachkontengruppeGuvSummenzeile>();
            Sachkontos = new HashSet<Sachkonto>();
        }

        public int Id { get; set; }
        public int? OberSachkontengruppeId { get; set; }
        public string Name { get; set; }
        public int? Reihenfolge { get; set; }
        public string GuvPositionString { get; set; }
        public bool? IstGuVposition { get; set; }
        public bool Aktiv { get; set; }

        public virtual Sachkontengruppe OberSachkontengruppe { get; set; }
        public virtual ICollection<Buchungstag> Buchungstags { get; set; }
        public virtual ICollection<GuvSummenzeile> GuvSummenzeiles { get; set; }
        public virtual ICollection<Sachkontengruppe> InverseOberSachkontengruppe { get; set; }
        public virtual ICollection<SachkontengruppeGuvSummenzeile> SachkontengruppeGuvSummenzeiles { get; set; }
        public virtual ICollection<Sachkonto> Sachkontos { get; set; }
    }
}
