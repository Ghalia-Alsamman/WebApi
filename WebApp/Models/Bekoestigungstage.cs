using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bekoestigungstage
    {
        public Bekoestigungstage()
        {
            BekoestigungstageCateringMahlzeits = new HashSet<BekoestigungstageCateringMahlzeit>();
        }

        public int Id { get; set; }
        public int? WarenwirtschaftskomponenteId { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }

        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
        public virtual ICollection<BekoestigungstageCateringMahlzeit> BekoestigungstageCateringMahlzeits { get; set; }
    }
}
