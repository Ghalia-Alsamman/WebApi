using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urlaub
    {
        public int Id { get; set; }
        public int UrlaubsinformationId { get; set; }
        public int UrlaubsartId { get; set; }
        public string Bemerkung { get; set; }
        public double VerbrauchteUrlaubstage { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }

        public virtual Urlaubsart Urlaubsart { get; set; }
        public virtual Urlaubsinformation Urlaubsinformation { get; set; }
    }
}
