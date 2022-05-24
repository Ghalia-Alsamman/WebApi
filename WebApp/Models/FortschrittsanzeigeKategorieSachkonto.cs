using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class FortschrittsanzeigeKategorieSachkonto
    {
        public int Id { get; set; }
        public int FortschrittsanzeigeKategorieId { get; set; }
        public int SachkontoId { get; set; }

        public virtual FortschrittsanzeigeKategorie FortschrittsanzeigeKategorie { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
