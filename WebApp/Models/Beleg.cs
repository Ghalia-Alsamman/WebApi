using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Beleg
    {
        public Beleg()
        {
            AuftragArtikelVerkaufs = new HashSet<AuftragArtikelVerkauf>();
            AuftragMenueplanZeitpunkts = new HashSet<AuftragMenueplanZeitpunkt>();
            AuftragVerleihartikels = new HashSet<AuftragVerleihartikel>();
            AuftragZuschlags = new HashSet<AuftragZuschlag>();
            InverseOberBeleg = new HashSet<Beleg>();
            KundeVerleihartikels = new HashSet<KundeVerleihartikel>();
            Mahnungs = new HashSet<Mahnung>();
        }

        public int Id { get; set; }
        public int BelegartId { get; set; }
        public int? AuftragId { get; set; }
        public int? KundeId { get; set; }
        public int? BelegJournalId { get; set; }
        public int BenutzerId { get; set; }
        public int? AuftragstatusId { get; set; }
        public int? OberBelegId { get; set; }
        public double? Rechnungsbetrag { get; set; }
        public string Belegnummer { get; set; }
        public DateTime? Belegdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }
        public bool? IstSammelrechnungVerband { get; set; }

        public virtual Auftrag Auftrag { get; set; }
        public virtual Auftragstatus Auftragstatus { get; set; }
        public virtual BelegJournal BelegJournal { get; set; }
        public virtual Belegart Belegart { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Beleg OberBeleg { get; set; }
        public virtual ICollection<AuftragArtikelVerkauf> AuftragArtikelVerkaufs { get; set; }
        public virtual ICollection<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual ICollection<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual ICollection<AuftragZuschlag> AuftragZuschlags { get; set; }
        public virtual ICollection<Beleg> InverseOberBeleg { get; set; }
        public virtual ICollection<KundeVerleihartikel> KundeVerleihartikels { get; set; }
        public virtual ICollection<Mahnung> Mahnungs { get; set; }
    }
}
