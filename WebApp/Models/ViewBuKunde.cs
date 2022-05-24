using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKunde
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Mitgliedsnummer { get; set; }
        public string Unternehmen { get; set; }
        public string Anrede { get; set; }
        public string Kategorie { get; set; }
        public string Kontaktart { get; set; }
        public string Ansprechpartnerart { get; set; }
        public string Titel { get; set; }
        public string Position { get; set; }
        public string Notizen { get; set; }
        public string BestellnummerRechn { get; set; }
        public string AdresszusatzRechn { get; set; }
        public string StrRechn { get; set; }
        public string HausnrRechn { get; set; }
        public string OrtRechn { get; set; }
        public string Plzrechn { get; set; }
        public bool? IstPostfRechn { get; set; }
        public string PostfRechn { get; set; }
        public string PostfPlzrechn { get; set; }
        public string PostfOrtRechn { get; set; }
        public string LandRechn { get; set; }
        public string LandKrzlRechn { get; set; }
        public string AbteilungRechn { get; set; }
        public string StrGesch { get; set; }
        public string HausnrGesch { get; set; }
        public string OrtGesch { get; set; }
        public string Plzgesch { get; set; }
        public bool? IstPostfGesch { get; set; }
        public string PostfGesch { get; set; }
        public string PostfPlzgesch { get; set; }
        public string PostfOrtGesch { get; set; }
        public string LandGesch { get; set; }
        public string LandKrzlGesch { get; set; }
        public string AbteilungGesch { get; set; }
        public string Url { get; set; }
        public string Mail { get; set; }
        public string Mail2 { get; set; }
        public string Tel { get; set; }
        public string Tel2 { get; set; }
        public string Mobiltel { get; set; }
        public string TelFax { get; set; }
        public int? AnzahlMitgl { get; set; }
        public string Mitgliedschaftsart { get; set; }
        public double? Beitrag { get; set; }
        public double? SteuerMitgliedsbeit { get; set; }
        public string MitgliedschaftsartUnternehmen { get; set; }
        public DateTime? MitgliedschaftStartdatum { get; set; }
        public DateTime? MitgliedschaftEnddatum { get; set; }
        public DateTime? MitgliedschaftKuendigungsdatum { get; set; }
    }
}
