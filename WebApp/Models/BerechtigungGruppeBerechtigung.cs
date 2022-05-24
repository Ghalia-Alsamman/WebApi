using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungGruppeBerechtigung
    {
        public int Id { get; set; }
        public int GruppeId { get; set; }
        public int BerechtigungId { get; set; }
        public int? BerechtigungObjektTypId { get; set; }

        public virtual Berechtigung Berechtigung { get; set; }
        public virtual BerechtigungObjektTyp BerechtigungObjektTyp { get; set; }
        public virtual Gruppe Gruppe { get; set; }
    }
}
