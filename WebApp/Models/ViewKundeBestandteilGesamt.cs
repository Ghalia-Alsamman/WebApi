using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilGesamt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Ansprechpartnerart { get; set; }
        public string Debitorennummer { get; set; }
        public string Unternehmen { get; set; }
        public string DebitorennummerVater { get; set; }
        public string StrasseRechnung { get; set; }
        public string HausnummerRechnung { get; set; }
        public string OrtRechnung { get; set; }
        public string PlzRechnung { get; set; }
        public bool? IstpostfachRechnung { get; set; }
        public string PostfachRechnung { get; set; }
        public string PostfachplzRechnung { get; set; }
        public string LandnameRechnung { get; set; }
        public string LandcodeRechnung { get; set; }
        public string PostfachOrtRechnung { get; set; }
        public string BestellnummerRechnung { get; set; }
        public string AdresszusatzRechnung { get; set; }
        public string AbteilungRechnung { get; set; }
        public string StrasseGeschaeftlich { get; set; }
        public string HausnummerGeschaeftlich { get; set; }
        public string OrtGeschaeftlich { get; set; }
        public string PlzGeschaeftlich { get; set; }
        public bool? IstpostfachGeschaeftlich { get; set; }
        public string PostfachGeschaeftlich { get; set; }
        public string PostfachplzGeschaeftlich { get; set; }
        public string PostfachOrtGeschaeftlich { get; set; }
        public string LandnameGeschaeftlich { get; set; }
        public string LandcodeGeschaeftlich { get; set; }
        public string AbteilungGeschaeftlich { get; set; }
        public string Anrede { get; set; }
        public string Url { get; set; }
        public string MailadresseGeschaeftlich { get; set; }
        public string MailadressePrivat { get; set; }
        public string Telefonnummergeschaeftlich { get; set; }
        public string Telefonnummerprivat { get; set; }
        public string Telefonnummermobil { get; set; }
        public string Telefonfax { get; set; }
        public int? MitgliedschaftArtId { get; set; }
        public string MitgliedschaftArt { get; set; }
        public int? MitgliedschaftArtUnternehmenId { get; set; }
        public string MitgliedschaftArtUnternehmen { get; set; }
        public int? AnzahlMitgliedschaft { get; set; }
        public double? Mitgliedsbeitrag { get; set; }
        public double? Mitgliedssteuer { get; set; }
        public string Kundenkategorie { get; set; }
        public string Kundenart { get; set; }
        public string Titel { get; set; }
        public string Position { get; set; }
        public string Bemerkung { get; set; }
        public string UnternehmensnameRechnung { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Enddatum { get; set; }
        public DateTime? Kuendigungdatum { get; set; }
    }
}
