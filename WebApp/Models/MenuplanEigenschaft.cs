using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenuplanEigenschaft
    {
        public MenuplanEigenschaft()
        {
            Menueplans = new HashSet<Menueplan>();
        }

        public int Id { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime GueltigBis { get; set; }
        public bool Montag { get; set; }
        public bool Dienstag { get; set; }
        public bool Mittwoch { get; set; }
        public bool Donnerstag { get; set; }
        public bool Freitag { get; set; }
        public bool Samstag { get; set; }
        public bool Sonntag { get; set; }

        public virtual ICollection<Menueplan> Menueplans { get; set; }
    }
}
