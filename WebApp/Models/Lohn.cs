using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Lohn
    {
        public int Id { get; set; }
        public int VerguetungsinformationId { get; set; }
        public int VerguetungsartId { get; set; }
        public double Hoehe { get; set; }
        public string Bemerkung { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }

        public virtual Verguetungsart Verguetungsart { get; set; }
        public virtual Verguetungsinformation Verguetungsinformation { get; set; }
    }
}
