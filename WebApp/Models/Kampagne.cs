using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kampagne
    {
        public Kampagne()
        {
            Erloesplanungszeiles = new HashSet<Erloesplanungszeile>();
            KampagneGruppens = new HashSet<KampagneGruppen>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? KalkulationId { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual ICollection<Erloesplanungszeile> Erloesplanungszeiles { get; set; }
        public virtual ICollection<KampagneGruppen> KampagneGruppens { get; set; }
    }
}
