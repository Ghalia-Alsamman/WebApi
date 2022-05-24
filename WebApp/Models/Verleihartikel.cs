using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verleihartikel
    {
        public Verleihartikel()
        {
            AuftragVerleihartikels = new HashSet<AuftragVerleihartikel>();
            KundeVerleihartikels = new HashSet<KundeVerleihartikel>();
            Preis = new HashSet<Prei>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int VerleihartikelkategorieId { get; set; }
        public string Name { get; set; }
        public int Menge { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Verleihartikelkategorie Verleihartikelkategorie { get; set; }
        public virtual ICollection<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual ICollection<KundeVerleihartikel> KundeVerleihartikels { get; set; }
        public virtual ICollection<Prei> Preis { get; set; }
    }
}
