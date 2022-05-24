using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalplanGeplanterTag
    {
        public PersonalplanGeplanterTag()
        {
            PersonalplanGeplanteZeiteinheits = new HashSet<PersonalplanGeplanteZeiteinheit>();
        }

        public int Id { get; set; }
        public int PersonalplanId { get; set; }
        public DateTime Tag { get; set; }

        public virtual Personalplan Personalplan { get; set; }
        public virtual ICollection<PersonalplanGeplanteZeiteinheit> PersonalplanGeplanteZeiteinheits { get; set; }
    }
}
