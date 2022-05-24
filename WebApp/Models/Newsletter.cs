using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Newsletter
    {
        public Newsletter()
        {
            NewsletterKundes = new HashSet<NewsletterKunde>();
            NewsletterMailEmpfaengers = new HashSet<NewsletterMailEmpfaenger>();
            NewsletterVerteilers = new HashSet<NewsletterVerteiler>();
        }

        public int Id { get; set; }
        public int MailNachrichtId { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual MailNachricht MailNachricht { get; set; }
        public virtual ICollection<NewsletterKunde> NewsletterKundes { get; set; }
        public virtual ICollection<NewsletterMailEmpfaenger> NewsletterMailEmpfaengers { get; set; }
        public virtual ICollection<NewsletterVerteiler> NewsletterVerteilers { get; set; }
    }
}
