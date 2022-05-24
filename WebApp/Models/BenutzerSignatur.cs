using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerSignatur
    {
        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string Signatur { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
    }
}
