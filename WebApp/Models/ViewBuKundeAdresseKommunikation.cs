using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKundeAdresseKommunikation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Kundennr { get; set; }
        public string Anrede { get; set; }
        public string Kategorie { get; set; }
        public string Kontaktart { get; set; }
        public string Ansprechpartnerart { get; set; }
        public string Titel { get; set; }
        public string StrGesch { get; set; }
        public string HausnrGesch { get; set; }
        public string OrtGesch { get; set; }
        public string Plzgesch { get; set; }
        public bool? IstPostfGesch { get; set; }
        public string PostfGesch { get; set; }
        public string PostfPlzgesch { get; set; }
        public string PostfOrtGesch { get; set; }
        public string LandGesch { get; set; }
        public string AbteilungGesch { get; set; }
        public string Mail { get; set; }
        public string Mail2 { get; set; }
        public string Tel { get; set; }
        public string Tel2 { get; set; }
        public string Mobiltel { get; set; }
        public string TelFax { get; set; }
        public string MitgliedschaftArt { get; set; }
        public string MitgliedschaftArtUnternehmen { get; set; }
    }
}
