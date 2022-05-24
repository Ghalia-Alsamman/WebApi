using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ArtikelmerklisteEintrag
    {
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public int BenutzerId { get; set; }
        public double Menge { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Benutzer Benutzer { get; set; }
    }
}
