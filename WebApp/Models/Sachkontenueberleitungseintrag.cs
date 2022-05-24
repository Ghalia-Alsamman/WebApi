using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkontenueberleitungseintrag
    {
        public int Id { get; set; }
        public int SachkontenueberleitungId { get; set; }
        public int AltesSachkonto { get; set; }
        public int NeuesSachkonto { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Sachkontenueberleitung Sachkontenueberleitung { get; set; }
    }
}
