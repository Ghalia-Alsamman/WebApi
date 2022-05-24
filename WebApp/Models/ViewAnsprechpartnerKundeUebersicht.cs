using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAnsprechpartnerKundeUebersicht
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Telefonnummer { get; set; }
        public string Faxnummer { get; set; }
        public string Mailadresse { get; set; }
        public string Stellenbeschreibung { get; set; }
    }
}
