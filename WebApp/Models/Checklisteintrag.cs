using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Checklisteintrag
    {
        public Checklisteintrag()
        {
            ChecklisteneintragVeranstaltungs = new HashSet<ChecklisteneintragVeranstaltung>();
        }

        public int Id { get; set; }
        public int ChecklisteintragArtId { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ChecklisteintragArt ChecklisteintragArt { get; set; }
        public virtual ICollection<ChecklisteneintragVeranstaltung> ChecklisteneintragVeranstaltungs { get; set; }
    }
}
