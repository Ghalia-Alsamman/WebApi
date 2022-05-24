using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mitarbeiter
    {
        public Mitarbeiter()
        {
            Kontaktinformations = new HashSet<Kontaktinformation>();
            PersonalplanGeplanteZeiteinheitMitarbeiters = new HashSet<PersonalplanGeplanteZeiteinheitMitarbeiter>();
        }

        public int Id { get; set; }
        public int PersonalkategorieId { get; set; }
        public int? BenutzerId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Personalnummer { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool Aktiv { get; set; }
        public bool Deaktiviert { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Personalkategorie Personalkategorie { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<PersonalplanGeplanteZeiteinheitMitarbeiter> PersonalplanGeplanteZeiteinheitMitarbeiters { get; set; }
    }
}
