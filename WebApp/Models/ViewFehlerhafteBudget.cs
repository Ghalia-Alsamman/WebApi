using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewFehlerhafteBudget
    {
        public int Id { get; set; }
        public double Differenz { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? Jahr { get; set; }
        public bool IstMfp { get; set; }
        public string Kalkulationsname { get; set; }
    }
}
