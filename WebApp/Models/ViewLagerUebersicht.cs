using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLagerUebersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BenutzerVorname { get; set; }
        public string BenutzerName { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public int? ArtikelId { get; set; }
        public double? LagerArtikelDurchschnittspreis { get; set; }
    }
}
