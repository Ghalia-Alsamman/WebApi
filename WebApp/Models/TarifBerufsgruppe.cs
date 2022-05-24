using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class TarifBerufsgruppe
    {
        public int Id { get; set; }
        public int TarifId { get; set; }
        public int BerufsgruppeId { get; set; }
        public double Weihnachtsgeldsatz { get; set; }
        public DateTime? GueltigAb { get; set; }
        public int? SonderzahlungId { get; set; }
        public double PraemieFix { get; set; }
        public bool PraemieStattWeihnachtsgeld { get; set; }

        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Sonderzahlungen Sonderzahlung { get; set; }
        public virtual Tarif Tarif { get; set; }
    }
}
