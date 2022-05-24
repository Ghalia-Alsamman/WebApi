using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AuftragArtikelVerkauf
    {
        public int Id { get; set; }
        public int? AuftragId { get; set; }
        public int? BelegId { get; set; }
        public int ArtikelVerkaufId { get; set; }
        public int? SteuernId { get; set; }
        public int? ReklamationsgrundId { get; set; }
        public int? Belegposition { get; set; }
        public string Kommentar { get; set; }
        public double Anzahl { get; set; }
        public double? Sollmenge { get; set; }
        public double Verkaufspreis { get; set; }
        public string Bemerkung { get; set; }
        public bool WirdRueckerstattet { get; set; }
        public bool IstWarenrueckname { get; set; }
        public bool? AufLieferscheinDrucken { get; set; }

        public virtual ArtikelVerkauf ArtikelVerkauf { get; set; }
        public virtual Auftrag Auftrag { get; set; }
        public virtual Beleg Beleg { get; set; }
        public virtual Reklamationsgrund Reklamationsgrund { get; set; }
        public virtual Steuern Steuern { get; set; }
    }
}
