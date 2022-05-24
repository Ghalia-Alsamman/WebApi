using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator
    {
        public int Id { get; set; }
        public int BenutzerUebersichtId { get; set; }
        public int BenutzerUebersichtBasisTypBenutzerUebersichtOperatorId { get; set; }
        public string Spalte { get; set; }
        public string Filtertext { get; set; }

        public virtual BenutzerUebersicht BenutzerUebersicht { get; set; }
        public virtual BenutzerUebersichtBasisTypBenutzerUebersichtOperator BenutzerUebersichtBasisTypBenutzerUebersichtOperator { get; set; }
    }
}
