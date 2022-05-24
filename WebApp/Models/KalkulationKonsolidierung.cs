using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationKonsolidierung
    {
        public int Id { get; set; }
        public int? KonsolidierungId { get; set; }
        public int? KalkulationId { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
    }
}
