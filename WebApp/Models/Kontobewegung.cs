using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kontobewegung
    {
        public int Id { get; set; }
        public int InternesKontoId { get; set; }
        public int BenutzerId { get; set; }
        public int? KontoId { get; set; }
        public string Betreff { get; set; }
        public double Betrag { get; set; }
        public string Buchungsnummer { get; set; }
        public string Belegnummer { get; set; }
        public int? KontobewegungsartId { get; set; }
        public int? GrundObjektId { get; set; }
        public string GrundObjektTyp { get; set; }
        public DateTime Belegdatum { get; set; }
        public DateTime Buchungsdatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual InternesKonto InternesKonto { get; set; }
        public virtual Konto Konto { get; set; }
    }
}
