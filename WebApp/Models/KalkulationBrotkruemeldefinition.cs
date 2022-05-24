using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationBrotkruemeldefinition
    {
        public KalkulationBrotkruemeldefinition()
        {
            StrategischeKalkulationBrotkruemeldefinitions = new HashSet<StrategischeKalkulationBrotkruemeldefinition>();
        }

        public int Id { get; set; }
        public int KalkulationsartId { get; set; }
        public string UcType { get; set; }
        public string EnumBerechtigungsString { get; set; }
        public string EnumBerechtigungsStringAlternativ { get; set; }
        public string EnumBerechtigungsStringAlleLesen { get; set; }
        public string EnumBerechtigungsStringRoot { get; set; }
        public int Reihenfolge { get; set; }

        public virtual Kalkulationsart Kalkulationsart { get; set; }
        public virtual ICollection<StrategischeKalkulationBrotkruemeldefinition> StrategischeKalkulationBrotkruemeldefinitions { get; set; }
    }
}
