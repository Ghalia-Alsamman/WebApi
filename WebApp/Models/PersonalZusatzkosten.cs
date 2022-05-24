using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalZusatzkosten
    {
        public int Id { get; set; }
        public int? PersonalId { get; set; }
        public double? Fahrtkosten { get; set; }
        public double? Mietkosten { get; set; }
        public double? Mobilitaetszuschlag { get; set; }
        public double? Sonstiges { get; set; }
        public DateTime Datum { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
