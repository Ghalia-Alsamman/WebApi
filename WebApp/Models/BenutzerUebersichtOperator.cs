using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersichtOperator
    {
        public BenutzerUebersichtOperator()
        {
            BenutzerUebersichtBasisTypBenutzerUebersichtOperators = new HashSet<BenutzerUebersichtBasisTypBenutzerUebersichtOperator>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SqlBefehl { get; set; }
        public bool? IstFiltertextAktiv { get; set; }

        public virtual ICollection<BenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
    }
}
