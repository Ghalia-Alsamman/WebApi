using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Vertretungspersonal
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public double? FachkraftUrlaub { get; set; }
        public double? FachkraftKrankheit { get; set; }
        public double? HilfskraftUrlaub { get; set; }
        public double? HilfskraftKrankheit { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
    }
}
