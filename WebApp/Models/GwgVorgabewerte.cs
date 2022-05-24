using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class GwgVorgabewerte
    {
        public int Id { get; set; }
        public double GwgWert { get; set; }
        public double GwgBetrag { get; set; }
        public bool Aktiv { get; set; }
    }
}
