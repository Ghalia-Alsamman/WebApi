using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Rabattinformationen
    {
        public int Id { get; set; }
        public int KontaktinformationId { get; set; }
        public double? Bonus { get; set; }
        public double? Skonto { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
    }
}
