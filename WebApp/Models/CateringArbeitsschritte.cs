using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringArbeitsschritte
    {
        public CateringArbeitsschritte()
        {
            CateringArbeitsschritteMahlzeits = new HashSet<CateringArbeitsschritteMahlzeit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? ZeitProStueck { get; set; }
        public bool Verteilungprobkt { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<CateringArbeitsschritteMahlzeit> CateringArbeitsschritteMahlzeits { get; set; }
    }
}
