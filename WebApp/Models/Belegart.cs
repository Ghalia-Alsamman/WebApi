using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Belegart
    {
        public Belegart()
        {
            Belegs = new HashSet<Beleg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string BelegnummerVorsilbe { get; set; }
        public bool VorblattFuerVerband { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Beleg> Belegs { get; set; }
    }
}
