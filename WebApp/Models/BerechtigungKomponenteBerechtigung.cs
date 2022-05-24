using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungKomponenteBerechtigung
    {
        public int Id { get; set; }
        public int RechteId { get; set; }
        public int BerechtigungKomponenteId { get; set; }

        public virtual BerechtigungKomponente BerechtigungKomponente { get; set; }
        public virtual Berechtigung Rechte { get; set; }
    }
}
