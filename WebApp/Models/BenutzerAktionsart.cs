using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerAktionsart
    {
        public BenutzerAktionsart()
        {
            BenutzerAktions = new HashSet<BenutzerAktion>();
        }

        public int Id { get; set; }
        public string Art { get; set; }

        public virtual ICollection<BenutzerAktion> BenutzerAktions { get; set; }
    }
}
