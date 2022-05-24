using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkontenueberleitung
    {
        public Sachkontenueberleitung()
        {
            Sachkontenueberleitungseintrags = new HashSet<Sachkontenueberleitungseintrag>();
        }

        public int Id { get; set; }
        public int TypId { get; set; }
        public string Beschreibung { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime GueltigBis { get; set; }
        public bool KstTransferieren { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Typ Typ { get; set; }
        public virtual ICollection<Sachkontenueberleitungseintrag> Sachkontenueberleitungseintrags { get; set; }
    }
}
