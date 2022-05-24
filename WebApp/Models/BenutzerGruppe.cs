using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerGruppe
    {
        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int GruppenId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Gruppe Gruppen { get; set; }
    }
}
