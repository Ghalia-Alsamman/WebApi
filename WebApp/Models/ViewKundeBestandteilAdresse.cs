using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilAdresse
    {
        public int? Id { get; set; }
        public string StrasseRechnung { get; set; }
        public string HausnummerRechnung { get; set; }
        public string OrtRechnung { get; set; }
        public string PlzRechnung { get; set; }
        public bool? IstpostfachRechnung { get; set; }
        public string PostfachRechnung { get; set; }
        public string PostfachplzRechnung { get; set; }
        public string LandnameRechnung { get; set; }
        public string LandcodeRechnung { get; set; }
        public string StrasseGeschaeftlich { get; set; }
        public string HausnummerGeschaeftlich { get; set; }
        public string OrtGeschaeftlich { get; set; }
        public string PlzGeschaeftlich { get; set; }
        public bool? IstpostfachGeschaeftlich { get; set; }
        public string PostfachGeschaeftlich { get; set; }
        public string PostfachplzGeschaeftlich { get; set; }
        public string LandnameGeschaeftlich { get; set; }
        public string LandcodeGeschaeftlich { get; set; }
        public string AbteilungGeschaeftlich { get; set; }
        public string PostfachOrtRechnung { get; set; }
        public string PostfachOrtGeschaeftlich { get; set; }
        public string BestellnummerRechnung { get; set; }
        public string AdresszusatzRechnung { get; set; }
        public string AbteilungRechnung { get; set; }
        public string UnternehmensnameRechnung { get; set; }
    }
}
