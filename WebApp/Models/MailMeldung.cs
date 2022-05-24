using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MailMeldung
    {
        public int Id { get; set; }
        public int MailnachrichtId { get; set; }
        public string Meldung { get; set; }

        public virtual MailNachricht Mailnachricht { get; set; }
    }
}
