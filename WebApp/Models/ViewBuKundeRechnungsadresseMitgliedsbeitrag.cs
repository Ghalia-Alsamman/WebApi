using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKundeRechnungsadresseMitgliedsbeitrag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Kundennr { get; set; }
        public string Anrede { get; set; }
        public string Kontaktart { get; set; }
        public string Ansprechpartnerart { get; set; }
        public string Titel { get; set; }
        public string Notizen { get; set; }
        public string Mail { get; set; }
        public string UnternehmensnameRechn { get; set; }
        public string StrRechn { get; set; }
        public string HausnrRechn { get; set; }
        public string OrtRechn { get; set; }
        public string Plzrechn { get; set; }
        public bool? IstPostfRechn { get; set; }
        public string PostfRechn { get; set; }
        public string PostfPlzrechn { get; set; }
        public string PostfOrtRechn { get; set; }
        public string BestellnummerRechn { get; set; }
        public string LandRechn { get; set; }
        public string AdresszusatzRechn { get; set; }
        public string AbteilungRechn { get; set; }
        public int? AnzahlMitgl { get; set; }
        public string Mitgliedschaftsart { get; set; }
        public string MitgliedschaftArtUnternehmen { get; set; }
        public double? Beitrag { get; set; }
        public double? SteuerMitgliedsbeit { get; set; }
    }
}
