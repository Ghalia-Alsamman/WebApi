using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Tarif
    {
        public Tarif()
        {
            KonsolidierungPersonals = new HashSet<KonsolidierungPersonal>();
            Personals = new HashSet<Personal>();
            TarifBerufsgruppes = new HashSet<TarifBerufsgruppe>();
            TarifPersonalabgabens = new HashSet<TarifPersonalabgaben>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string Nummer { get; set; }
        public string Name { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<TarifBerufsgruppe> TarifBerufsgruppes { get; set; }
        public virtual ICollection<TarifPersonalabgaben> TarifPersonalabgabens { get; set; }
    }
}
