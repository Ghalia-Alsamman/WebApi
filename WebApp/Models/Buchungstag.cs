using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Buchungstag
    {
        public int Id { get; set; }
        public int BuchungstagDefinitionId { get; set; }
        public int SachkontenkategorieId { get; set; }
        public int? SachkontoId { get; set; }
        public int? SachkontengruppeId { get; set; }
        public int Tag { get; set; }
        public bool DarfUeberschriebenWerden { get; set; }

        public virtual BuchungstagDefinition BuchungstagDefinition { get; set; }
        public virtual Sachkontengruppe Sachkontengruppe { get; set; }
        public virtual Sachkontenkategorie Sachkontenkategorie { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
