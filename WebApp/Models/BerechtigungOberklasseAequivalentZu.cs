using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungOberklasseAequivalentZu
    {
        public BerechtigungOberklasseAequivalentZu()
        {
            BerechtigungKlasseTyps = new HashSet<BerechtigungKlasseTyp>();
        }

        public int Id { get; set; }
        public int? IstOberrechtId { get; set; }
        public bool FremdschluesselIstId { get; set; }
        public string PropertyName { get; set; }

        public virtual BerechtigungKlasseTyp IstOberrecht { get; set; }
        public virtual ICollection<BerechtigungKlasseTyp> BerechtigungKlasseTyps { get; set; }
    }
}
