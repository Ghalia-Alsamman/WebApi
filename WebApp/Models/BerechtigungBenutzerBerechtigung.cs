using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungBenutzerBerechtigung
    {
        public int Id { get; set; }
        public int BerechtigungId { get; set; }
        public int BenutzerId { get; set; }
        public int? BerechtigungObjektTypId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Berechtigung Berechtigung { get; set; }
        public virtual BerechtigungObjektTyp BerechtigungObjektTyp { get; set; }
    }
}
