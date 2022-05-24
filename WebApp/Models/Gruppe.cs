using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Gruppe
    {
        public Gruppe()
        {
            BenutzerGruppes = new HashSet<BenutzerGruppe>();
            BerechtigungGruppeBerechtigungs = new HashSet<BerechtigungGruppeBerechtigung>();
            KampagneGruppens = new HashSet<KampagneGruppen>();
        }

        public int Id { get; set; }
        public int? RechteId { get; set; }
        public string Name { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }
        public int? RegionalleitungId { get; set; }

        public virtual Rechte Rechte { get; set; }
        public virtual Benutzer Regionalleitung { get; set; }
        public virtual ICollection<BenutzerGruppe> BenutzerGruppes { get; set; }
        public virtual ICollection<BerechtigungGruppeBerechtigung> BerechtigungGruppeBerechtigungs { get; set; }
        public virtual ICollection<KampagneGruppen> KampagneGruppens { get; set; }
    }
}
