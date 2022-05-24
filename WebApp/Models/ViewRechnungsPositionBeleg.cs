using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewRechnungsPositionBeleg
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public string Debitorennummer { get; set; }
        public string Debitorenname { get; set; }
        public int? OberBelegId { get; set; }
        public string OberBelegnummer { get; set; }
        public string BelegartName { get; set; }
        public DateTime? OberBelegdatum { get; set; }
        public int? AuftragId { get; set; }
        public string Belegnummer { get; set; }
        public double? Rechnungsbetrag { get; set; }
        public DateTime? Belegdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
    }
}
