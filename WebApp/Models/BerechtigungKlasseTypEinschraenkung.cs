using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungKlasseTypEinschraenkung
    {
        public int Id { get; set; }
        public int BerechtigungId { get; set; }
        public int BerechtigungKlasseTypId { get; set; }
        public string Verbindungspropertie { get; set; }
        public bool IstPropertyIdFeld { get; set; }
        public bool Aktiv { get; set; }

        public virtual Berechtigung Berechtigung { get; set; }
        public virtual BerechtigungKlasseTyp BerechtigungKlasseTyp { get; set; }
    }
}
