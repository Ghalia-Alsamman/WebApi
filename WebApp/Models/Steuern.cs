using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Steuern
    {
        public Steuern()
        {
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
            Artikels = new HashSet<Artikel>();
            AuftragArtikelVerkaufs = new HashSet<AuftragArtikelVerkauf>();
            AuftragMenueplanZeitpunkts = new HashSet<AuftragMenueplanZeitpunkt>();
            AuftragVerleihartikels = new HashSet<AuftragVerleihartikel>();
            AuftragZuschlags = new HashSet<AuftragZuschlag>();
            KundeVerleihartikels = new HashSet<KundeVerleihartikel>();
            Sachkontos = new HashSet<Sachkonto>();
            TransferArtikels = new HashSet<TransferArtikel>();
            Zuschlags = new HashSet<Zuschlag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Prozent { get; set; }
        public string Kennzeichen { get; set; }
        public bool Standardsatz { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual ICollection<Artikel> Artikels { get; set; }
        public virtual ICollection<AuftragArtikelVerkauf> AuftragArtikelVerkaufs { get; set; }
        public virtual ICollection<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual ICollection<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual ICollection<AuftragZuschlag> AuftragZuschlags { get; set; }
        public virtual ICollection<KundeVerleihartikel> KundeVerleihartikels { get; set; }
        public virtual ICollection<Sachkonto> Sachkontos { get; set; }
        public virtual ICollection<TransferArtikel> TransferArtikels { get; set; }
        public virtual ICollection<Zuschlag> Zuschlags { get; set; }
    }
}
