using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AuslastungMonat
    {
        public int Id { get; set; }
        public int KalkulationAuslastungsartId { get; set; }
        public double? BelegtePlaetzeProTag { get; set; }
        public double? AnwesenheitPst0 { get; set; }
        public double? AnwesenheitPst1 { get; set; }
        public double? AnwesenheitPst2 { get; set; }
        public double? AnwesenheitPst3 { get; set; }
        public double? AnwesenheitPst3plus { get; set; }
        public double? AbwesenheitenProTag { get; set; }
        public double? AbwesenheitPst0 { get; set; }
        public double? AbwesenheitPst1 { get; set; }
        public double? AbwesenheitPst2 { get; set; }
        public double? AbwesenheitPst3 { get; set; }
        public double? AbwesenheitPst3plus { get; set; }
        public double? TageBelegteEz { get; set; }
        public double? TageSondennahrung { get; set; }
        public double? AnteilSelbstzahler { get; set; }
        public int Monat { get; set; }
        public double? AnteilShe { get; set; }
        public double? AnteilInv3 { get; set; }
        public double? AnteilInv4 { get; set; }
        public double? AnteilInv5 { get; set; }

        public virtual KalkulationAuslastungsart KalkulationAuslastungsart { get; set; }
    }
}
