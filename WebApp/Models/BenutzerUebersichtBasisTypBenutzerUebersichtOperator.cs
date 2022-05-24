using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersichtBasisTypBenutzerUebersichtOperator
    {
        public BenutzerUebersichtBasisTypBenutzerUebersichtOperator()
        {
            BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators = new HashSet<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator>();
        }

        public int Id { get; set; }
        public int BenutzerUebersichtBasisTypId { get; set; }
        public int BenutzerUebersichtOperatorId { get; set; }

        public virtual BenutzerUebersichtBasisTyp BenutzerUebersichtBasisTyp { get; set; }
        public virtual BenutzerUebersichtOperator BenutzerUebersichtOperator { get; set; }
        public virtual ICollection<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
    }
}
