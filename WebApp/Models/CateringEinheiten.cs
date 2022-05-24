using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringEinheiten
    {
        public CateringEinheiten()
        {
            CateringArbeitsschritteMahlzeits = new HashSet<CateringArbeitsschritteMahlzeit>();
            CateringProduktivzeitens = new HashSet<CateringProduktivzeiten>();
        }

        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public double Montag { get; set; }
        public double Dienstag { get; set; }
        public double Mittwoch { get; set; }
        public double Donnerstag { get; set; }
        public double Freitag { get; set; }
        public double Samstag { get; set; }
        public double Sonntag { get; set; }
        public double Feiertags { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual ICollection<CateringArbeitsschritteMahlzeit> CateringArbeitsschritteMahlzeits { get; set; }
        public virtual ICollection<CateringProduktivzeiten> CateringProduktivzeitens { get; set; }
    }
}
