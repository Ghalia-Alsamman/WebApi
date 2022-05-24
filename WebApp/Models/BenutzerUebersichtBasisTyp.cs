using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersichtBasisTyp
    {
        public BenutzerUebersichtBasisTyp()
        {
            BenutzerUebersichtBasisTypBenutzerUebersichtOperators = new HashSet<BenutzerUebersichtBasisTypBenutzerUebersichtOperator>();
        }

        public int Id { get; set; }
        public string Typ { get; set; }
        public bool? IstFiltertextAktiv { get; set; }

        public virtual ICollection<BenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
    }
}
