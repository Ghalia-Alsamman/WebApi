using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Lieferdaten
    {
        public int Id { get; set; }
        public int KontaktinformationId { get; set; }
        public double? Mindestbestellwert { get; set; }
        public double? Porto { get; set; }
        public double? Rabatt { get; set; }
        public double? Skonto { get; set; }
        public bool? WareMussAbgeholtWerden { get; set; }
        public int? Bestellkanal { get; set; }
        public int? Dauer { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
    }
}
