using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Standardkommunikationskanal
    {
        public Standardkommunikationskanal()
        {
            Kontaktinformations = new HashSet<Kontaktinformation>();
        }

        public int Id { get; set; }
        public string KlassenTyp { get; set; }
        public int ObjektId { get; set; }

        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
    }
}
