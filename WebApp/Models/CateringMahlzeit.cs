using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringMahlzeit
    {
        public CateringMahlzeit()
        {
            BekoestigungstageCateringMahlzeits = new HashSet<BekoestigungstageCateringMahlzeit>();
            CateringArbeitsschritteMahlzeits = new HashSet<CateringArbeitsschritteMahlzeit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Standard { get; set; }
        public double? Gewichtung { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<BekoestigungstageCateringMahlzeit> BekoestigungstageCateringMahlzeits { get; set; }
        public virtual ICollection<CateringArbeitsschritteMahlzeit> CateringArbeitsschritteMahlzeits { get; set; }
    }
}
