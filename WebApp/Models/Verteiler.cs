using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verteiler
    {
        public Verteiler()
        {
            NewsletterVerteilers = new HashSet<NewsletterVerteiler>();
            VerteilerKundes = new HashSet<VerteilerKunde>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int? BenutzerUebersichtId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual BenutzerUebersicht BenutzerUebersicht { get; set; }
        public virtual ICollection<NewsletterVerteiler> NewsletterVerteilers { get; set; }
        public virtual ICollection<VerteilerKunde> VerteilerKundes { get; set; }
    }
}
