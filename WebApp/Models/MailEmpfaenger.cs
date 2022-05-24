using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MailEmpfaenger
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public int MailempfaengerartId { get; set; }
        public int? KundeId { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public bool Verarbeitet { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual MailNachricht Mail { get; set; }
        public virtual MailEmpfaengerart Mailempfaengerart { get; set; }
    }
}
