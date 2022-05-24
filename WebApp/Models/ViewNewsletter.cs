using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewNewsletter
    {
        public int? Id { get; set; }
        public int MailNachrichtId { get; set; }
        public string Name { get; set; }
        public string Betreff { get; set; }
        public bool? IstEntwurf { get; set; }
        public int? AnzahlMeldungen { get; set; }
        public int? AnzahlVerarbeitet { get; set; }
        public int? AnzahlNichtVerarbeitet { get; set; }
        public double? ProzentVerarbeitet { get; set; }
        public DateTime? Versanddatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
    }
}
