using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelle
    {
        public int Id { get; set; }
        public int LiquiditaetsplanungKontoId { get; set; }
        public int LiquiditaetsplanungKostenstelle { get; set; }
        public int Typ { get; set; }
        public DateTime Datum { get; set; }
        public string Betreff { get; set; }
        public double Planwert { get; set; }
        public double? Istwert { get; set; }
        public double KontostandPlan { get; set; }
        public double? KontostandIst { get; set; }

        public virtual Liquiditaetsplanungkonto LiquiditaetsplanungKonto { get; set; }
        public virtual LiquiditaetsplanungKostenstelle LiquiditaetsplanungKostenstelleNavigation { get; set; }
    }
}
