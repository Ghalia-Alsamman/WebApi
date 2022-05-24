using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            Ansprechpartners = new HashSet<Ansprechpartner>();
            Benutzers = new HashSet<Benutzer>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
            Lieferants = new HashSet<Lieferant>();
            Sonderveranstaltungs = new HashSet<Sonderveranstaltung>();
            Warenwirtschaftskomponentes = new HashSet<Warenwirtschaftskomponente>();
        }

        public int Id { get; set; }
        public int? AdressartId { get; set; }
        public int? KontaktinformationId { get; set; }
        public int? LandId { get; set; }
        public string Name { get; set; }
        public string Adresszusatz { get; set; }
        public string Firmenname { get; set; }
        public string Strasse { get; set; }
        public string Hausnumer { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string LandText { get; set; }
        public string Telefon { get; set; }
        public string Telefax { get; set; }
        public bool? IstStandard { get; set; }
        public bool IstPostfach { get; set; }
        public string Postfach { get; set; }
        public string PostfachPlz { get; set; }
        public string PostfachOrt { get; set; }
        public string PersonenName { get; set; }
        public string BestellNummer { get; set; }
        public string Abteilung { get; set; }
        public string Email { get; set; }

        public virtual Adressart Adressart { get; set; }
        public virtual Kontaktinformation Kontaktinformation { get; set; }
        public virtual Land Land { get; set; }
        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<Benutzer> Benutzers { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual ICollection<Lieferant> Lieferants { get; set; }
        public virtual ICollection<Sonderveranstaltung> Sonderveranstaltungs { get; set; }
        public virtual ICollection<Warenwirtschaftskomponente> Warenwirtschaftskomponentes { get; set; }
    }
}
