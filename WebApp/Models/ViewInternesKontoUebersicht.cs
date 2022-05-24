using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewInternesKontoUebersicht
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int? KundeVerbandId { get; set; }
        public string KundenName { get; set; }
        public string Debitorennummer { get; set; }
        public decimal? Kontostand { get; set; }
        public DateTime? LetzteAenderung { get; set; }
    }
}
