using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAuslastungMonat
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public int AuslastungsartId { get; set; }
        public int Monat { get; set; }
        public double? BelegungPst0proTag { get; set; }
        public double? BelegungPst0 { get; set; }
        public double? BelegungPst1proTag { get; set; }
        public double? BelegungPst1 { get; set; }
        public double? BelegungPst2proTag { get; set; }
        public double? BelegungPst2 { get; set; }
        public double? BelegungPst3proTag { get; set; }
        public double? BelegungPst3 { get; set; }
        public double? BelegungPst3plusproTag { get; set; }
        public double? BelegungPst3plus { get; set; }
        public double? AbwesenheitPst0proTag { get; set; }
        public double? AbwesenheitPst0 { get; set; }
        public double? AbwesenheitPst1proTag { get; set; }
        public double? AbwesenheitPst1 { get; set; }
        public double? AbwesenheitPst2proTag { get; set; }
        public double? AbwesenheitPst2 { get; set; }
        public double? AbwesenheitPst3proTag { get; set; }
        public double? AbwesenheitPst3 { get; set; }
        public double? AbwesenheitPst3plusproTag { get; set; }
        public double? AbwesenheitPst3plus { get; set; }
        public double? TageBelegteEz { get; set; }
        public double? TageSondennahrung { get; set; }
        public double? AnteilSelbstzahler { get; set; }
    }
}
