using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KundeArtikel
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int ArtikelId { get; set; }
        public string Kundenartikelnummer { get; set; }
        public string Kundenartikelname { get; set; }

        public virtual Artikel Artikel { get; set; }
        public virtual Kunde Kunde { get; set; }
    }
}
