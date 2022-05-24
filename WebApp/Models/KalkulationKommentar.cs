using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationKommentar
    {
        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public int? BenutzerId { get; set; }
        public DateTime Datum { get; set; }
        public string Kommentar { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
    }
}
