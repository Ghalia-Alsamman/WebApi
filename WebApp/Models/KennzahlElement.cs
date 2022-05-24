using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KennzahlElement
    {
        public int Id { get; set; }
        public int? OberKennzahlId { get; set; }
        public int? KennzahlOperatorId { get; set; }
        public int? KennzahlElementTypId { get; set; }
        public int? KennzahlId { get; set; }
        public int? KennzahlElementObjektId { get; set; }
        public double? Wert { get; set; }
        public int ReihenfolgeNr { get; set; }

        public virtual Kennzahl Kennzahl { get; set; }
        public virtual KennzahlElementTyp KennzahlElementTyp { get; set; }
        public virtual KennzahlOperator KennzahlOperator { get; set; }
        public virtual Kennzahl OberKennzahl { get; set; }
    }
}
