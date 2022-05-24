using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MitgliedschaftArt
    {
        public MitgliedschaftArt()
        {
            Mitgliedschafts = new HashSet<Mitgliedschaft>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Mitgliedschaft> Mitgliedschafts { get; set; }
    }
}
