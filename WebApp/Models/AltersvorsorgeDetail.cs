using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AltersvorsorgeDetail
    {
        public int Id { get; set; }
        public int AltersvorsorgeId { get; set; }
        public double Prozentsatz { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime GueltigBis { get; set; }

        public virtual Altersvorsorge Altersvorsorge { get; set; }
    }
}
