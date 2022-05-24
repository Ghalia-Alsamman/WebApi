using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewMailNachricht
    {
        public int? Id { get; set; }
        public string Betreff { get; set; }
        public int? AnzahlMeldungen { get; set; }
        public bool? IstEntwurf { get; set; }
        public DateTime? Versanddatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
    }
}
