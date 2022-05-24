using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalAuslastungszeile
    {
        public int Id { get; set; }
        public int? PersonalId { get; set; }
        public int PersonalAuslastungsart { get; set; }
        public double Januar { get; set; }
        public double Februar { get; set; }
        public double Maerz { get; set; }
        public double April { get; set; }
        public double Mai { get; set; }
        public double Juni { get; set; }
        public double Juli { get; set; }
        public double August { get; set; }
        public double September { get; set; }
        public double Oktober { get; set; }
        public double November { get; set; }
        public double Dezember { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
