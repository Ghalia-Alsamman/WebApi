using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bundesland
    {
        public Bundesland()
        {
            Abwesenheitsregels = new HashSet<Abwesenheitsregel>();
            Ansprechpartners = new HashSet<Ansprechpartner>();
            Arbeitstages = new HashSet<Arbeitstage>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? AltesBundesland { get; set; }

        public virtual ICollection<Abwesenheitsregel> Abwesenheitsregels { get; set; }
        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<Arbeitstage> Arbeitstages { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
    }
}
