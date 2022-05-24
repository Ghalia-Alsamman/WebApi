using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Veranstaltungsteilnehmerart
    {
        public Veranstaltungsteilnehmerart()
        {
            VeranstaltungKundes = new HashSet<VeranstaltungKunde>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<VeranstaltungKunde> VeranstaltungKundes { get; set; }
    }
}
