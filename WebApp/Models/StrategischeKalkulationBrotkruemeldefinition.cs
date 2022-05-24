using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class StrategischeKalkulationBrotkruemeldefinition
    {
        public int Id { get; set; }
        public int KalkulationBrotkruemeldefinitionId { get; set; }
        public string Type { get; set; }
        public int Reihenfolge { get; set; }

        public virtual KalkulationBrotkruemeldefinition KalkulationBrotkruemeldefinition { get; set; }
    }
}
