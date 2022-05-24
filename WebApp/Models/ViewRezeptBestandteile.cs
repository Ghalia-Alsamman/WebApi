using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewRezeptBestandteile
    {
        public long? Id { get; set; }
        public int? RezeptId { get; set; }
        public string Name { get; set; }
        public string AnzeigeName { get; set; }
        public string Rezeptkategorie { get; set; }
        public int? Ausgabemenge { get; set; }
        public string Ausgabemengeneinheit { get; set; }
        public bool? IstMenuebestandteil { get; set; }
        public string Bestandteil { get; set; }
        public double Menge { get; set; }
        public string Mengeneinheit { get; set; }
        public string Art { get; set; }
    }
}
