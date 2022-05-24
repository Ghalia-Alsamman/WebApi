using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Liquiditaetsplanungkonto
    {
        public Liquiditaetsplanungkonto()
        {
            LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelles = new HashSet<LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Nummer { get; set; }
        public double Anfangsbestand { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelle> LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelles { get; set; }
    }
}
