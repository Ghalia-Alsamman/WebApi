using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KundeVerleihartikel
    {
        public int Id { get; set; }
        public int VerleihartikelId { get; set; }
        public int? AuftragId { get; set; }
        public int? BelegId { get; set; }
        public int KundeId { get; set; }
        public int? SteuernId { get; set; }
        public double Menge { get; set; }
        public string Kommentar { get; set; }
        public int? Belegposition { get; set; }
        public DateTime Buchungsdatum { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public double? ManuellerVerleihpreis { get; set; }
        public bool Vernichtet { get; set; }

        public virtual Auftrag Auftrag { get; set; }
        public virtual Beleg Beleg { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual Verleihartikel Verleihartikel { get; set; }
    }
}
