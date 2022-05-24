using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kalkulationsart
    {
        public Kalkulationsart()
        {
            KalkulationBrotkruemeldefinitions = new HashSet<KalkulationBrotkruemeldefinition>();
            Kalkulations = new HashSet<Kalkulation>();
            KalkulationsartBerechtigungLesens = new HashSet<KalkulationsartBerechtigungLesen>();
            Kostenstelles = new HashSet<Kostenstelle>();
            StrategischeKalkulations = new HashSet<StrategischeKalkulation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnumBerechtigungSchreiben { get; set; }
        public string EnumBerechtigungEntsperren { get; set; }
        public string EnumBerechtigungExportieren { get; set; }
        public string EnumBerechtigungAlleSchreiben { get; set; }
        public string EnumBerechtigungLesen { get; set; }
        public bool VertretungspersonalAktiv { get; set; }

        public virtual ICollection<KalkulationBrotkruemeldefinition> KalkulationBrotkruemeldefinitions { get; set; }
        public virtual ICollection<Kalkulation> Kalkulations { get; set; }
        public virtual ICollection<KalkulationsartBerechtigungLesen> KalkulationsartBerechtigungLesens { get; set; }
        public virtual ICollection<Kostenstelle> Kostenstelles { get; set; }
        public virtual ICollection<StrategischeKalkulation> StrategischeKalkulations { get; set; }
    }
}
