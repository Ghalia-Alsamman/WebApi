using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilAdresseRechnung
    {
        public int Id { get; set; }
        public string StrasseRechnung { get; set; }
        public string HausnummerRechnung { get; set; }
        public string OrtRechnung { get; set; }
        public string PlzRechnung { get; set; }
        public bool IstpostfachRechnung { get; set; }
        public string PostfachRechnung { get; set; }
        public string PostfachplzRechnung { get; set; }
        public string LandnameRechnung { get; set; }
        public string LandcodeRechnung { get; set; }
        public string PostfachOrt { get; set; }
        public string UnternehmensnameRechnung { get; set; }
        public string BestellNummer { get; set; }
        public string Adresszusatz { get; set; }
        public string Abteilung { get; set; }
    }
}
