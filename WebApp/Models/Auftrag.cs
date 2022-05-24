using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Auftrag
    {
        public Auftrag()
        {
            AuftragArtikelVerkaufs = new HashSet<AuftragArtikelVerkauf>();
            AuftragAuftragstatuses = new HashSet<AuftragAuftragstatus>();
            AuftragMenueplanZeitpunkts = new HashSet<AuftragMenueplanZeitpunkt>();
            AuftragVerleihartikels = new HashSet<AuftragVerleihartikel>();
            AuftragZuschlags = new HashSet<AuftragZuschlag>();
            Belegs = new HashSet<Beleg>();
            KundeVerleihartikels = new HashSet<KundeVerleihartikel>();
        }

        public int Id { get; set; }
        public int KundeId { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public int? KommentarId { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public string AuftragsnummerIntern { get; set; }
        public string AuftragsnummerExtern { get; set; }
        public DateTime? AngebotGueltigBis { get; set; }
        public DateTime? GeplantFuer { get; set; }
        public DateTime? Bestelldatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public double Auftragsvolumen { get; set; }
        public bool Aktiv { get; set; }

        public virtual Ansprechpartner Ansprechpartner { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kommentar Kommentar { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual ICollection<AuftragArtikelVerkauf> AuftragArtikelVerkaufs { get; set; }
        public virtual ICollection<AuftragAuftragstatus> AuftragAuftragstatuses { get; set; }
        public virtual ICollection<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual ICollection<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual ICollection<AuftragZuschlag> AuftragZuschlags { get; set; }
        public virtual ICollection<Beleg> Belegs { get; set; }
        public virtual ICollection<KundeVerleihartikel> KundeVerleihartikels { get; set; }
    }
}
