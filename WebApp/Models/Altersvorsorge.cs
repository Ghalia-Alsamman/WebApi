using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Altersvorsorge
    {
        public Altersvorsorge()
        {
            AltersvorsorgeDetails = new HashSet<AltersvorsorgeDetail>();
            KonsolidierungPersonals = new HashSet<KonsolidierungPersonal>();
            Personals = new HashSet<Personal>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }
        public string ImportKuerzel { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<AltersvorsorgeDetail> AltersvorsorgeDetails { get; set; }
        public virtual ICollection<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
