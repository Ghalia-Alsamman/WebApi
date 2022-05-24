using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAlleNichtAbgeschlossenenBestellObjekt
    {
        public int Id { get; set; }
        public DateTime? Bestelldatum { get; set; }
        public DateTime? Lieferdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string Bestellnummer { get; set; }
        public string Name { get; set; }
        public string BeschreibungStatus { get; set; }
        public string BearbeiterName { get; set; }
        public string Lieferant { get; set; }
    }
}
