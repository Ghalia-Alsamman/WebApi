using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Traeger
    {
        public Traeger()
        {
            Ansprechpartners = new HashSet<Ansprechpartner>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
    }
}
