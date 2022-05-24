using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Transaktion
    {
        public int Id { get; set; }
        public string Kontennummer { get; set; }
        public string Bezeichnung { get; set; }
        public double? Betrag { get; set; }
        public DateTime? Datum { get; set; }
    }
}
