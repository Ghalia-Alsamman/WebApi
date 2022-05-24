using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ImportLog
    {
        public int Id { get; set; }
        public int MailZugangsdatenId { get; set; }
        public int BenutzerId { get; set; }
        public string Quellautor { get; set; }
        public DateTime Quelldatum { get; set; }
        public int AnzahlDatensaetze { get; set; }
        public int AnzahlNeueDatensaetze { get; set; }
        public int AnzahlGeaenderteDatensaetze { get; set; }
        public int AnzahlGeloeschteDatensaetze { get; set; }
        public int AnzahlFehler { get; set; }
        public string Bemerkung { get; set; }
        public DateTime Erstellungsdatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual MailZugangsdaten MailZugangsdaten { get; set; }
    }
}
