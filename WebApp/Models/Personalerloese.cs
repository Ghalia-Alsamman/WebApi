using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalerloese
    {
        public int Id { get; set; }
        public int? PersonalId { get; set; }
        public int? BerufsgruppeId { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public double? Tagessatz { get; set; }
        public double? Fakturaquote { get; set; }

        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Personal Personal { get; set; }
    }
}
