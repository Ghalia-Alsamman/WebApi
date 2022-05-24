using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalplan
    {
        public Personalplan()
        {
            PersonalplanGeplanterTags = new HashSet<PersonalplanGeplanterTag>();
            PersonalplanPersonalplanregels = new HashSet<PersonalplanPersonalplanregel>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int PersonalplankategorieId { get; set; }
        public string Name { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime PlanzeitVon { get; set; }
        public DateTime PlanzeitBis { get; set; }
        public int? GroesseZeiteinheitInMinuten { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Personalplankategorie Personalplankategorie { get; set; }
        public virtual ICollection<PersonalplanGeplanterTag> PersonalplanGeplanterTags { get; set; }
        public virtual ICollection<PersonalplanPersonalplanregel> PersonalplanPersonalplanregels { get; set; }
    }
}
