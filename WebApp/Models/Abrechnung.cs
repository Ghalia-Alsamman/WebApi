using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Abrechnung
    {
        public int Id { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public double? KasseIst { get; set; }
        public string Kassenbezeichnung { get; set; }
        public double? KasseSollXabschlag { get; set; }
        public double? KasseSollZabschlag { get; set; }
        public double? KorrekturFehlbons { get; set; }
        public double? Wechselbestand { get; set; }
        public double? EntnahmenAusRegistrierkassen { get; set; }

        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
    }
}
