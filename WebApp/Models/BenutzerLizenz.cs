using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerLizenz
    {
        public int Id { get; set; }
        public int? BenutzerId { get; set; }
        public int? LizenzId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Lizenz Lizenz { get; set; }
    }
}
