using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Prei
    {
        public Prei()
        {
            Staffelpreis = new HashSet<Staffelprei>();
        }

        public int Id { get; set; }
        public int? ArtikelEinkaufId { get; set; }
        public int? ArtikelVerkaufId { get; set; }
        public int? RezeptId { get; set; }
        public int? VerleihartikelId { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ArtikelEinkauf ArtikelEinkauf { get; set; }
        public virtual ArtikelVerkauf ArtikelVerkauf { get; set; }
        public virtual Rezept Rezept { get; set; }
        public virtual Verleihartikel Verleihartikel { get; set; }
        public virtual ICollection<Staffelprei> Staffelpreis { get; set; }
    }
}
