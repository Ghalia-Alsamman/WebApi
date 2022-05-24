using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class LagerWarenwirtschaftskomponente
    {
        public int Id { get; set; }
        public int? LagerId { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }

        public virtual Lager Lager { get; set; }
        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
    }
}
