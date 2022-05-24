using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBelegJournal
    {
        public int Id { get; set; }
        public int BelegJournalId { get; set; }
        public int? KundeId { get; set; }
        public int BenutzerId { get; set; }
        public int? AuftragstatusId { get; set; }
        public int? OberBelegId { get; set; }
        public string Belegnummer { get; set; }
        public DateTime? Belegdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public int Expr2 { get; set; }
        public DateTime Expr3 { get; set; }
        public string Bezeichnung { get; set; }
    }
}
