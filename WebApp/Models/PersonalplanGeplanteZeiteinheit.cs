using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalplanGeplanteZeiteinheit
    {
        public PersonalplanGeplanteZeiteinheit()
        {
            PersonalplanGeplanteZeiteinheitMitarbeiters = new HashSet<PersonalplanGeplanteZeiteinheitMitarbeiter>();
        }

        public int Id { get; set; }
        public int PersonalplanGeplanterTagId { get; set; }
        public DateTime Zeitpunkt { get; set; }

        public virtual PersonalplanGeplanterTag PersonalplanGeplanterTag { get; set; }
        public virtual ICollection<PersonalplanGeplanteZeiteinheitMitarbeiter> PersonalplanGeplanteZeiteinheitMitarbeiters { get; set; }
    }
}
