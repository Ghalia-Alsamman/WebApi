using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DarlehenZusatztilgung
    {
        public int Id { get; set; }
        public int DarlehenId { get; set; }
        public double Betrag { get; set; }
        public DateTime Datum { get; set; }
        public DateTime? Enddatum { get; set; }

        public virtual Darlehen Darlehen { get; set; }
    }
}
