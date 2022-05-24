using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationAufschlaege
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public double? SummeGewerbesteuer { get; set; }
        public double? SummeKoerperschaftssteuer { get; set; }
        public double? SummeVorsteuerVoll { get; set; }
        public double? SummeVorsteuerErmaessigt { get; set; }
        public double? RisikoGewinnaufschlag { get; set; }
        public double? Verwaltungsaufschlag { get; set; }
        public double? Endsumme { get; set; }
        public double OperativesMgmtAufschlag { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
    }
}
