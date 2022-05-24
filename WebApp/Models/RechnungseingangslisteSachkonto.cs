using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class RechnungseingangslisteSachkonto
    {
        public int Id { get; set; }
        public int? RechnungseingangslisteId { get; set; }
        public int? SachkontoId { get; set; }
        public int? LieferantId { get; set; }
        public double? Betrag { get; set; }

        public virtual Lieferant Lieferant { get; set; }
        public virtual Rechnungseingangsliste Rechnungseingangsliste { get; set; }
    }
}
