using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class StrategischeKalkulationKonsolidierung
    {
        public int Id { get; set; }
        public int StrategischeKalkulationId { get; set; }
        public int KonsolidierungId { get; set; }

        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual StrategischeKalkulation StrategischeKalkulation { get; set; }
    }
}
