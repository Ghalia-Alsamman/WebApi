using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerUebersicht
    {
        public BenutzerUebersicht()
        {
            BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators = new HashSet<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator>();
            Verteilers = new HashSet<Verteiler>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int? NavigationsbereichId { get; set; }
        public int BenutzeruebersichtbasisId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Sqlstring { get; set; }
        public bool? IstUndVerknuepfung { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual BenutzerUebersichtBasis Benutzeruebersichtbasis { get; set; }
        public virtual Navigationsbereich Navigationsbereich { get; set; }
        public virtual ICollection<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
        public virtual ICollection<Verteiler> Verteilers { get; set; }
    }
}
