using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KennzahlElementTyp
    {
        public KennzahlElementTyp()
        {
            InverseOberKennzahlElementTyp = new HashSet<KennzahlElementTyp>();
            KennzahlElements = new HashSet<KennzahlElement>();
        }

        public int Id { get; set; }
        public int? OberKennzahlElementTypId { get; set; }
        public string Name { get; set; }
        public string AnzeigeEigenschaft { get; set; }
        public string WertEigenschaft { get; set; }
        public string WertEigenschaft2 { get; set; }
        public string WertEigenschaft3 { get; set; }
        public string WertMethode { get; set; }
        public bool SingulaerLaden { get; set; }
        public bool? Aktiv { get; set; }

        public virtual KennzahlElementTyp OberKennzahlElementTyp { get; set; }
        public virtual ICollection<KennzahlElementTyp> InverseOberKennzahlElementTyp { get; set; }
        public virtual ICollection<KennzahlElement> KennzahlElements { get; set; }
    }
}
