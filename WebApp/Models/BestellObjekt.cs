using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BestellObjekt
    {
        public BestellObjekt()
        {
            BestellObjektArtikels = new HashSet<BestellObjektArtikel>();
        }

        public int Id { get; set; }
        public int BestellStatusId { get; set; }
        public int BenutzerId { get; set; }
        public DateTime? Bestelldatum { get; set; }
        public DateTime? Lieferdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string Bestellnummer { get; set; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual BestellObjektStatus BestellStatus { get; set; }
        public virtual ICollection<BestellObjektArtikel> BestellObjektArtikels { get; set; }
    }
}
