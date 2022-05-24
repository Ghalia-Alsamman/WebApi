using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungKlasseTyp
    {
        public BerechtigungKlasseTyp()
        {
            BerechtigungKlasseTypEinschraenkungs = new HashSet<BerechtigungKlasseTypEinschraenkung>();
            BerechtigungOberklasseAequivalentZus = new HashSet<BerechtigungOberklasseAequivalentZu>();
            BerechtigungObjektTyps = new HashSet<BerechtigungObjektTyp>();
            Berechtigungs = new HashSet<Berechtigung>();
            InverseOberBerechtigungKlasseTyp = new HashSet<BerechtigungKlasseTyp>();
        }

        public int Id { get; set; }
        public int? OberBerechtigungKlasseTypId { get; set; }
        public int? BerechtigungOberklasseAequivalentZuId { get; set; }
        public string Klassenname { get; set; }
        public string Anzeigename { get; set; }
        public bool Aktiv { get; set; }

        public virtual BerechtigungOberklasseAequivalentZu BerechtigungOberklasseAequivalentZu { get; set; }
        public virtual BerechtigungKlasseTyp OberBerechtigungKlasseTyp { get; set; }
        public virtual ICollection<BerechtigungKlasseTypEinschraenkung> BerechtigungKlasseTypEinschraenkungs { get; set; }
        public virtual ICollection<BerechtigungOberklasseAequivalentZu> BerechtigungOberklasseAequivalentZus { get; set; }
        public virtual ICollection<BerechtigungObjektTyp> BerechtigungObjektTyps { get; set; }
        public virtual ICollection<Berechtigung> Berechtigungs { get; set; }
        public virtual ICollection<BerechtigungKlasseTyp> InverseOberBerechtigungKlasseTyp { get; set; }
    }
}
