using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalplanregel
    {
        public Personalplanregel()
        {
            PersonalplanPersonalplanregels = new HashSet<PersonalplanPersonalplanregel>();
        }

        public int Id { get; set; }
        public double? BedarfAnzahlMitarbeiter { get; set; }
        public DateTime? KernzeitVon { get; set; }
        public DateTime? KernzeitBis { get; set; }

        public virtual ICollection<PersonalplanPersonalplanregel> PersonalplanPersonalplanregels { get; set; }
    }
}
