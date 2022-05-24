using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BekoestigungstageCateringMahlzeit
    {
        public int Id { get; set; }
        public int? Bekoestigungstageid { get; set; }
        public int? CateringMahlzeitId { get; set; }
        public double? Anzahl { get; set; }

        public virtual Bekoestigungstage Bekoestigungstage { get; set; }
        public virtual CateringMahlzeit CateringMahlzeit { get; set; }
    }
}
