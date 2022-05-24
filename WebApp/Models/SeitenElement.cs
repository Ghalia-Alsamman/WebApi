using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SeitenElement
    {
        public SeitenElement()
        {
            BenutzerSeitenElements = new HashSet<BenutzerSeitenElement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string UcName { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<BenutzerSeitenElement> BenutzerSeitenElements { get; set; }
    }
}
