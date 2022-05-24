using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mitgliedsbeitrag
    {
        public int Id { get; set; }
        public int? LandId { get; set; }
        public int? KundeId { get; set; }
        public DateTime Von { get; set; }
        public DateTime? Bis { get; set; }
        public double Beitrag { get; set; }
        public double Steuer { get; set; }
        public string Bemerkung { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Land Land { get; set; }
    }
}
