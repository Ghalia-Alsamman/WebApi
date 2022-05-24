using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kalkulationskennzahl
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public double Wert { get; set; }
        public int Typ { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
    }
}
