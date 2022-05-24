using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Artikelliste
    {
        public Artikelliste()
        {
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
            Artikels = new HashSet<Artikel>();
        }

        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public string Name { get; set; }
        public bool IstZentralliste { get; set; }
        public bool AfaListe { get; set; }
        public bool Aktiv { get; set; }
        public string Schluessel { get; set; }
        public bool? Rabattfaehig { get; set; }

        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual ICollection<Artikel> Artikels { get; set; }
    }
}
