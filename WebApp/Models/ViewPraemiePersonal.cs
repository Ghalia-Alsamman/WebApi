using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewPraemiePersonal
    {
        public int Id { get; set; }
        public int? BerufsgruppeId { get; set; }
        public int? KalkulationId { get; set; }
        public DateTime? DatumVon { get; set; }
        public DateTime? DatumBis { get; set; }
        public double? Einsatz { get; set; }
    }
}
