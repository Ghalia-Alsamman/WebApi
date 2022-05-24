using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KennzahlOperator
    {
        public KennzahlOperator()
        {
            KennzahlElements = new HashSet<KennzahlElement>();
        }

        public int Id { get; set; }
        public string OperatorText { get; set; }
        public string Funktionsname { get; set; }
        public int ReihenfolgeNr { get; set; }
        public string StringFuerAnzeige { get; set; }
        public string StringFuerRechnung { get; set; }
        public bool IstKlammerAuf { get; set; }
        public bool IstKlammerZu { get; set; }
        public int ErwarteteAnzahlParameter { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<KennzahlElement> KennzahlElements { get; set; }
    }
}
