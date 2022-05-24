using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class InternesKonto
    {
        public InternesKonto()
        {
            Kontobewegungs = new HashSet<Kontobewegung>();
        }

        public int Id { get; set; }
        public int KontoinformationId { get; set; }
        public int BenutzerId { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Kontoinformation Kontoinformation { get; set; }
        public virtual ICollection<Kontobewegung> Kontobewegungs { get; set; }
    }
}
