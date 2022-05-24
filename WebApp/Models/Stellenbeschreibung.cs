using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Stellenbeschreibung
    {
        public Stellenbeschreibung()
        {
            Ansprechpartners = new HashSet<Ansprechpartner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
    }
}
