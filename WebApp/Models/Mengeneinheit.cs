using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mengeneinheit
    {
        public Mengeneinheit()
        {
            ArtikelEinkaufs = new HashSet<ArtikelEinkauf>();
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
            Artikels = new HashSet<Artikel>();
            RezeptAusgabeeinheits = new HashSet<Rezept>();
            RezeptMengeneinheits = new HashSet<Rezept>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Kuerzel { get; set; }

        public virtual ICollection<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual ICollection<Artikel> Artikels { get; set; }
        public virtual ICollection<Rezept> RezeptAusgabeeinheits { get; set; }
        public virtual ICollection<Rezept> RezeptMengeneinheits { get; set; }
    }
}
