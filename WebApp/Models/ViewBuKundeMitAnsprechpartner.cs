using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuKundeMitAnsprechpartner
    {
        public int Id { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public string Unternehmen { get; set; }
        public string Kürzel { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string EmailUnternehmen { get; set; }
        public string DebitorenNr { get; set; }
        public string Adresszusatz { get; set; }
        public string Hausnummer { get; set; }
        public string Anrede { get; set; }
        public string Anredetext { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string TelefonnummerAnsprechpartner { get; set; }
        public string FaxnummerAnsprechpartner { get; set; }
        public string EmailAnsprechhpartner { get; set; }
        public string Stellenbeschreibung { get; set; }
    }
}
