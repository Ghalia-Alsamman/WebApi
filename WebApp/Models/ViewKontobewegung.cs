using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKontobewegung
    {
        public int Id { get; set; }
        public int InternesKontoId { get; set; }
        public int BenutzerId { get; set; }
        public string Betreff { get; set; }
        public decimal? Betrag { get; set; }
        public string Buchungsnummer { get; set; }
        public string Belegnummer { get; set; }
        public int? KontobewegungsartId { get; set; }
        public int? GrundObjektId { get; set; }
        public string GrundObjektTyp { get; set; }
        public DateTime Belegdatum { get; set; }
        public DateTime Buchungsdatum { get; set; }
        public string Benutzername { get; set; }
    }
}
