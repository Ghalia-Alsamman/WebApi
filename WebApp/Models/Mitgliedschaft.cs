using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mitgliedschaft
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int MitgliedschaftArtId { get; set; }
        public DateTime Von { get; set; }
        public DateTime? Bis { get; set; }
        public DateTime? Kuendigungsdatum { get; set; }
        public string Bemerkung { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual MitgliedschaftArt MitgliedschaftArt { get; set; }
    }
}
