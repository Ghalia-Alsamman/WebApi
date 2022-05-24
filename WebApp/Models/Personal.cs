using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personal
    {
        public Personal()
        {
            PersonalAuslastungszeiles = new HashSet<PersonalAuslastungszeile>();
            PersonalZusatzkostens = new HashSet<PersonalZusatzkosten>();
            Personaleinsatzs = new HashSet<Personaleinsatz>();
            Personalerloeses = new HashSet<Personalerloese>();
            Praemies = new HashSet<Praemie>();
            SonderveranstaltungPersonals = new HashSet<SonderveranstaltungPersonal>();
        }

        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public int? BerufsgruppeId { get; set; }
        public int? ZuschussKontoId { get; set; }
        public int? TarifId { get; set; }
        public string Personalnummer { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Tarifgruppenname { get; set; }
        public double? Gehalt { get; set; }
        public double ZuschlagProMonat { get; set; }
        public double ZuschlagProMonatSvpflichtig { get; set; }
        public double? ArbeitszeitProWoche { get; set; }
        public double? Zuschuss { get; set; }
        public bool IstZdl { get; set; }
        public bool IstGfb { get; set; }
        public bool FruehstueckGestellt { get; set; }
        public bool MittagGestellt { get; set; }
        public bool AbendbrotGestellt { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? KeineAltersvorsorge { get; set; }
        public bool? IstVertretungspersonal { get; set; }
        public int? AltersvorsorgeId { get; set; }
        public string Entgeltgruppe { get; set; }
        public bool IstFachkraft { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Altersvorsorge Altersvorsorge { get; set; }
        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Tarif Tarif { get; set; }
        public virtual Sachkonto ZuschussKonto { get; set; }
        public virtual ICollection<PersonalAuslastungszeile> PersonalAuslastungszeiles { get; set; }
        public virtual ICollection<PersonalZusatzkosten> PersonalZusatzkostens { get; set; }
        public virtual ICollection<Personaleinsatz> Personaleinsatzs { get; set; }
        public virtual ICollection<Personalerloese> Personalerloeses { get; set; }
        public virtual ICollection<Praemie> Praemies { get; set; }
        public virtual ICollection<SonderveranstaltungPersonal> SonderveranstaltungPersonals { get; set; }
    }
}
