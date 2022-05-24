using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Rechnungseingangsliste
    {
        public Rechnungseingangsliste()
        {
            RechnungseingangslisteSachkontos = new HashSet<RechnungseingangslisteSachkonto>();
        }

        public int Id { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }
        public DateTime? Rechnungsdatum { get; set; }
        public int? Rechnungsnummer { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }

        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
        public virtual ICollection<RechnungseingangslisteSachkonto> RechnungseingangslisteSachkontos { get; set; }
    }
}
