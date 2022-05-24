using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewUmsatzProKunde
    {
        public int Id { get; set; }
        public int? KundeId { get; set; }
        public string Debitorennummer { get; set; }
        public string Debitor { get; set; }
        public double? Gesamtumsatz { get; set; }
        public DateTime? Datum { get; set; }
    }
}
