using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ImportHochrechnung
    {
        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public int? SachkontoId { get; set; }
        public double Hochrechnung { get; set; }
        public DateTime ImportDatum { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
