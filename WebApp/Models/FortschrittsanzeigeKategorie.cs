using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class FortschrittsanzeigeKategorie
    {
        public FortschrittsanzeigeKategorie()
        {
            FortschrittsanzeigeKategorieSachkontos = new HashSet<FortschrittsanzeigeKategorieSachkonto>();
            Sachkontos = new HashSet<Sachkonto>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int Sort { get; set; }
        public bool? Aktiv { get; set; }
        public bool BasisFuerProzent { get; set; }
        public bool FuerCat { get; set; }
        public bool? Autosumme { get; set; }

        public virtual ICollection<FortschrittsanzeigeKategorieSachkonto> FortschrittsanzeigeKategorieSachkontos { get; set; }
        public virtual ICollection<Sachkonto> Sachkontos { get; set; }
    }
}
