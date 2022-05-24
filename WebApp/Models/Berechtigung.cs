using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Berechtigung
    {
        public Berechtigung()
        {
            BerechtigungBenutzerBerechtigungs = new HashSet<BerechtigungBenutzerBerechtigung>();
            BerechtigungBerechtigungPrimaers = new HashSet<BerechtigungBerechtigung>();
            BerechtigungBerechtigungSekundaers = new HashSet<BerechtigungBerechtigung>();
            BerechtigungGruppeBerechtigungs = new HashSet<BerechtigungGruppeBerechtigung>();
            BerechtigungKlasseTypEinschraenkungs = new HashSet<BerechtigungKlasseTypEinschraenkung>();
            BerechtigungKomponenteBerechtigungs = new HashSet<BerechtigungKomponenteBerechtigung>();
            InverseIstAequivalentZuBerechtigung = new HashSet<Berechtigung>();
        }

        public int Id { get; set; }
        public int? KategorieId { get; set; }
        public int? KlasseId { get; set; }
        public int? IstAequivalentZuBerechtigungId { get; set; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public bool IstRoot { get; set; }
        public bool Aktiv { get; set; }

        public virtual Berechtigung IstAequivalentZuBerechtigung { get; set; }
        public virtual BerechtigungKategorie Kategorie { get; set; }
        public virtual BerechtigungKlasseTyp Klasse { get; set; }
        public virtual ICollection<BerechtigungBenutzerBerechtigung> BerechtigungBenutzerBerechtigungs { get; set; }
        public virtual ICollection<BerechtigungBerechtigung> BerechtigungBerechtigungPrimaers { get; set; }
        public virtual ICollection<BerechtigungBerechtigung> BerechtigungBerechtigungSekundaers { get; set; }
        public virtual ICollection<BerechtigungGruppeBerechtigung> BerechtigungGruppeBerechtigungs { get; set; }
        public virtual ICollection<BerechtigungKlasseTypEinschraenkung> BerechtigungKlasseTypEinschraenkungs { get; set; }
        public virtual ICollection<BerechtigungKomponenteBerechtigung> BerechtigungKomponenteBerechtigungs { get; set; }
        public virtual ICollection<Berechtigung> InverseIstAequivalentZuBerechtigung { get; set; }
    }
}
