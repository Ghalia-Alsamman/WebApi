using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Anrede
    {
        public Anrede()
        {
            Kontaktinformations = new HashSet<Kontaktinformation>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Anredetext { get; set; }

        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
    }
}
