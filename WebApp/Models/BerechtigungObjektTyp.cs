using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungObjektTyp
    {
        public BerechtigungObjektTyp()
        {
            BerechtigungBenutzerBerechtigungs = new HashSet<BerechtigungBenutzerBerechtigung>();
            BerechtigungGruppeBerechtigungs = new HashSet<BerechtigungGruppeBerechtigung>();
        }

        public int Id { get; set; }
        public int KlassenTypId { get; set; }
        public int Objektid { get; set; }

        public virtual BerechtigungKlasseTyp KlassenTyp { get; set; }
        public virtual ICollection<BerechtigungBenutzerBerechtigung> BerechtigungBenutzerBerechtigungs { get; set; }
        public virtual ICollection<BerechtigungGruppeBerechtigung> BerechtigungGruppeBerechtigungs { get; set; }
    }
}
