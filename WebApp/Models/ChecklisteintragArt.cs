using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ChecklisteintragArt
    {
        public ChecklisteintragArt()
        {
            Checklisteintrags = new HashSet<Checklisteintrag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Checklisteintrag> Checklisteintrags { get; set; }
    }
}
