using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Einrichtungskapazitaet
    {
        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public int AnzahlVollstationaer { get; set; }
        public int AnzahlTeilstationaer { get; set; }
        public int AnzahlKurzzeitpflege { get; set; }
        public int AnzVollstationaerEinz { get; set; }
        public int AnzKurzzeitpflegeEinz { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
    }
}
