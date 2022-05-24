using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKundeLoesungen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Kundennr { get; set; }
        public string Anrede { get; set; }
        public string Titel { get; set; }
        public string Kategorie { get; set; }
        public string MitgliedschaftArt { get; set; }
        public string MitgliedschaftArtUnternehmen { get; set; }
        public string Mail { get; set; }
        public string StrRechn { get; set; }
        public string HausnrRechn { get; set; }
        public string OrtRechn { get; set; }
        public string Plzrechn { get; set; }
        public bool? IstPostfRechn { get; set; }
        public string PostfRechn { get; set; }
        public string PostfPlzrechn { get; set; }
        public string LandRechn { get; set; }
        public string AbteilungRechn { get; set; }
        public string StrGesch { get; set; }
        public string HausnrGesch { get; set; }
        public string OrtGesch { get; set; }
        public string Plzgesch { get; set; }
        public bool? IstPostfGesch { get; set; }
        public string PostfGesch { get; set; }
        public string PostfPlzgesch { get; set; }
        public string LandGesch { get; set; }
        public string AbteilungGesch { get; set; }
        public int? Teamer { get; set; }
    }
}
