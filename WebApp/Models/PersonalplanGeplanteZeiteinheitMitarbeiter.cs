using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalplanGeplanteZeiteinheitMitarbeiter
    {
        public int Id { get; set; }
        public int MitarbeiterId { get; set; }
        public int PersonalplanGeplanteZeiteinheitId { get; set; }

        public virtual Mitarbeiter Mitarbeiter { get; set; }
        public virtual PersonalplanGeplanteZeiteinheit PersonalplanGeplanteZeiteinheit { get; set; }
    }
}
