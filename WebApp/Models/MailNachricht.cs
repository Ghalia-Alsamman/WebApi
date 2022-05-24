using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MailNachricht
    {
        public MailNachricht()
        {
            MailEmpfaengers = new HashSet<MailEmpfaenger>();
            MailMeldungs = new HashSet<MailMeldung>();
            Newsletters = new HashSet<Newsletter>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string Betreff { get; set; }
        public string Nachricht { get; set; }
        public string NachrichtRtf { get; set; }
        public bool IstEntwurf { get; set; }
        public string Absenderadresse { get; set; }
        public string Absender { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool VersandNichtVorAktiv { get; set; }
        public DateTime VersandNichtVor { get; set; }
        public DateTime? Versanddatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<MailEmpfaenger> MailEmpfaengers { get; set; }
        public virtual ICollection<MailMeldung> MailMeldungs { get; set; }
        public virtual ICollection<Newsletter> Newsletters { get; set; }
    }
}
