using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeUebersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Kundenart { get; set; }
        public int? KundenartId { get; set; }
        public string Kategorie { get; set; }
        public int? KundenkategorieId { get; set; }
        public int? KundeVerbandId { get; set; }
        public int? KundeAnsprechpartnerVaterId { get; set; }
        public string Kuerzel { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Telefonnummer { get; set; }
        public string Faxnummer { get; set; }
        public string Debitorennummer { get; set; }
        public string Adresszusatz { get; set; }
        public string Hausnumer { get; set; }
        public string MitgliedschaftArt { get; set; }
        public int? MitgliedschaftArtId { get; set; }
        public int? AnzahlMitgliedschaft { get; set; }
        public bool? IstErOderKindMitglied { get; set; }
        public bool? IstErOderKindSchnuppermitglied { get; set; }
        public bool? IstGesperrt { get; set; }
    }
}
