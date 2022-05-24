using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Reklamationsgrund
    {
        public Reklamationsgrund()
        {
            AuftragArtikelVerkaufs = new HashSet<AuftragArtikelVerkauf>();
            AuftragMenueplanZeitpunkts = new HashSet<AuftragMenueplanZeitpunkt>();
            AuftragVerleihartikels = new HashSet<AuftragVerleihartikel>();
            AuftragZuschlags = new HashSet<AuftragZuschlag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<AuftragArtikelVerkauf> AuftragArtikelVerkaufs { get; set; }
        public virtual ICollection<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual ICollection<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual ICollection<AuftragZuschlag> AuftragZuschlags { get; set; }
    }
}
