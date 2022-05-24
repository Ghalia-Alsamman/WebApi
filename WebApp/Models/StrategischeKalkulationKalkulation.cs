using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class StrategischeKalkulationKalkulation
    {
        public int Id { get; set; }
        public int StrategischeKalkulationId { get; set; }
        public int KalkulationId { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
        public virtual StrategischeKalkulation StrategischeKalkulation { get; set; }
    }
}
