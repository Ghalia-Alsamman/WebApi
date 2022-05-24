using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Staffelprei
    {
        public int Id { get; set; }
        public int PreisId { get; set; }
        public double VonMenge { get; set; }
        public double Nettopreis { get; set; }

        public virtual Prei Preis { get; set; }
    }
}
