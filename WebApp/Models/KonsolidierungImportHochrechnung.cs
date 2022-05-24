using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungImportHochrechnung
    {
        public int Id { get; set; }
        public int? KonsolidierungId { get; set; }
        public int? SachkontoId { get; set; }
        public double Hochrechnung { get; set; }
        public DateTime ImportDatum { get; set; }

        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
