using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BelegJournal
    {
        public BelegJournal()
        {
            Belegs = new HashSet<Beleg>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public string Bezeichnung { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<Beleg> Belegs { get; set; }
    }
}
