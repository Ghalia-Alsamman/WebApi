using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilAdresseGeschaeftlich
    {
        public int Id { get; set; }
        public int AdresseId { get; set; }
        public string StrasseGeschaeftlich { get; set; }
        public string HausnummerGeschaeftlich { get; set; }
        public string OrtGeschaeftlich { get; set; }
        public string PlzGeschaeftlich { get; set; }
        public bool IstpostfachGeschaeftlich { get; set; }
        public string PostfachGeschaeftlich { get; set; }
        public string PostfachplzGeschaeftlich { get; set; }
        public string LandnameGeschaeftlich { get; set; }
        public string LandcodeGeschaeftlich { get; set; }
        public string PostfachOrt { get; set; }
        public string Abteilung { get; set; }
    }
}
