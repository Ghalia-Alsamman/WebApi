using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class LiquiditaetsplanungZeile
    {
        public int Id { get; set; }
        public int FinanzplanungId { get; set; }
        public string Name { get; set; }
        public double Wert1 { get; set; }
        public double Wert2 { get; set; }
        public double Wert3 { get; set; }
        public double Wert4 { get; set; }
        public double Wert5 { get; set; }
        public double Wert6 { get; set; }
        public double Wert7 { get; set; }
        public double Wert8 { get; set; }
        public double Wert9 { get; set; }
        public double Wert10 { get; set; }
        public double Wert11 { get; set; }
        public double Wert12 { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Finanzplanung Finanzplanung { get; set; }
    }
}
