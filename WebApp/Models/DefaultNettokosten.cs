using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DefaultNettokosten
    {
        public int Id { get; set; }
        public double VerwaltungsProzent { get; set; }
        public double RisikoGewinnProzent { get; set; }
        public double OperMgmtAufschlagProzent { get; set; }
    }
}
