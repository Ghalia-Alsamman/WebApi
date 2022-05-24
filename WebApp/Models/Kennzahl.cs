using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kennzahl
    {
        public Kennzahl()
        {
            Ergebnisbewertungs = new HashSet<Ergebnisbewertung>();
            KennzahlElementKennzahls = new HashSet<KennzahlElement>();
            KennzahlElementOberKennzahls = new HashSet<KennzahlElement>();
            KennzahlKennzahlenberichts = new HashSet<KennzahlKennzahlenbericht>();
        }

        public int Id { get; set; }
        public int EinheitId { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public bool Anzeigen { get; set; }
        public bool IstdatenMitAusgeben { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Einheit Einheit { get; set; }
        public virtual ICollection<Ergebnisbewertung> Ergebnisbewertungs { get; set; }
        public virtual ICollection<KennzahlElement> KennzahlElementKennzahls { get; set; }
        public virtual ICollection<KennzahlElement> KennzahlElementOberKennzahls { get; set; }
        public virtual ICollection<KennzahlKennzahlenbericht> KennzahlKennzahlenberichts { get; set; }
    }
}
